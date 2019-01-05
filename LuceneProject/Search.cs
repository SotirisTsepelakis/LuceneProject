using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;
namespace LuceneProject
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = textBox1.Text.ToLower();
            var webclient = new WebClient();
            var pageSourceCode = webclient.DownloadString("http://en.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&titles=" + textBox1.Text + "&redirects=true");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(pageSourceCode);

            var fnode = doc.GetElementsByTagName("extract")[0];

            try
            {
                string ss = fnode.InnerText;
                Regex regex = new Regex("\\<[^\\>]*\\>");
                string.Format("Before:{0}", ss);
                ss = regex.Replace(ss, string.Empty);
                string result = String.Format(ss);
                richTextBox1.Text += result;

            }
            catch (Exception)
            {
                richTextBox1.Text = "error";
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyclopediaBaseDataSet.Favorites' table. You can move, or remove it, as needed.
            this.favoritesTableAdapter.Fill(this.cyclopediaBaseDataSet.Favorites);
            // TODO: This line of code loads data into the 'cyclopediaBaseDataSet.Articles' table. You can move, or remove it, as needed.
            this.articlesTableAdapter.Fill(this.cyclopediaBaseDataSet.Articles);

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to export ?";
            const string caption = "Export";
            DialogResult index = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (index == DialogResult.No)
            {

            }
            System.IO.File.WriteAllLines(@"C:\Users\Stratos\Desktop\indexPath\IndexData\" + textBox1.Text + ".doc", richTextBox1.Lines);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.ToLower();
            var webclient = new WebClient();
            var pageSourceCode = webclient.DownloadString("http://en.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&titles=" + textBox1.Text + "&redirects=true");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(pageSourceCode);

            XmlNodeList pagelist = doc.SelectNodes("//page");
            string title = "";


            foreach (XmlNode page in pagelist)
            {
                title = page.Attributes["title"].InnerText;

            }

            string category = comboBox1.Text;
            string content = richTextBox1.Text;

            articlesTableAdapter.InsertQuery(content, title, category);
            this.articlesTableAdapter.Fill(this.cyclopediaBaseDataSet.Articles);
        }

        private void FavoriteButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = textBox1.Text.ToLower();
            var webclient = new WebClient();
            var pageSourceCode = webclient.DownloadString("http://en.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&titles=" + textBox1.Text + "&redirects=true");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(pageSourceCode);

            XmlNodeList pagelist = doc.SelectNodes("//page");
            string title = "";

            foreach (XmlNode page in pagelist)
            {
                title = page.Attributes["title"].InnerText;

            }

            favoritesTableAdapter.InsertQuery(1, title);
            this.favoritesTableAdapter.Fill(this.cyclopediaBaseDataSet.Favorites);
        }

        private void Search_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyclopediaBaseDataSet.Favorites' table. You can move, or remove it, as needed.
            this.favoritesTableAdapter.Fill(this.cyclopediaBaseDataSet.Favorites);
            // TODO: This line of code loads data into the 'cyclopediaBaseDataSet.Articles' table. You can move, or remove it, as needed.
            this.articlesTableAdapter.Fill(this.cyclopediaBaseDataSet.Articles);

        }
    }
}

