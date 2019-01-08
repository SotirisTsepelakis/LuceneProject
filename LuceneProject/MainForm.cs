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
using LuceneProject.DatabaseDataSetTableAdapters;

namespace LuceneProject
{
    public partial class MainForm : Form
    {
        LemmaCategoryTableAdapter lemmaCategoryTableAdapter = new LemmaCategoryTableAdapter();
        FavotiteTableAdapter favotiteTableAdapter = new FavotiteTableAdapter();
        LemmaMediaTableAdapter lemmaMediaTableAdapter = new LemmaMediaTableAdapter();
        LemmaTableAdapter lemmaTableAdapter = new LemmaTableAdapter();
        MediaTableAdapter mediaTableAdapter = new MediaTableAdapter();
        private string uname;

        public MainForm()
        {
            InitializeComponent();
            using (Indexer indexer = new Indexer())
            {
                indexer.IndexDirectory = "Index";
                indexer.DataDirectory = "Data";
                indexer.Setup();

                indexer.Index();
            }
        }

        private void greekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInGreek form = new FormInGreek();
            form.ShowDialog();
            this.Close();
        }

        private void articleTableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
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
                richTextBox2.Text += result;

            }
            catch (Exception)
            {
                richTextBox2.Text = "error";
            }
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
            string content = richTextBox2.Text;

           
            lemmaTableAdapter.Insert(title);
            lemmaCategoryTableAdapter.Insert(category, title);
            mediaTableAdapter.Insert("doc", content);
            
           lemmaMediaTableAdapter.Insert(1, title);
            
        }

        private void FavoriteButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
            var webclient = new WebClient();
            var pageSourceCode = webclient.DownloadString("http://en.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&titles=" + textBox1.Text + "&redirects=true");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(pageSourceCode);

            XmlNodeList pagelist = doc.SelectNodes("//page");
            string title = "";
            string content = richTextBox2.Text;
            foreach (XmlNode page in pagelist)
            {
                title = page.Attributes["title"].InnerText;

            }

           // favotiteTableAdapter.Insert(title, username);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to export ?";
            const string caption = "Export";
            DialogResult index = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (index == DialogResult.No)
            {

            }
            System.IO.File.WriteAllLines(@"C:\Users\Stratos\Desktop\indexPath\IndexData\" + textBox1.Text + ".doc", richTextBox2.Lines);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string category = textBox2.Text;
            dataGridView1.DataSource = lemmaCategoryTableAdapter.GetDataByCategory(category);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void toolStripSignInButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();

            if (form.getLoggedIn())
            {
                toolStripSignInButton.Visible = false;
                toolStripRegisterButton.Visible = false;
                toolStripLabel2.Text = "Signed in as " + form.getUsernameToStore();
                toolStripLabel2.Font= new Font("Arial", 8, FontStyle.Bold);

                setUsername(form.getUsernameToStore());
            }
        }

        private void toolStripRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        void setUsername(string uname)
        {
            this.uname = uname;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string category = e.Node.Text;
            dataGridView1.DataSource = lemmaCategoryTableAdapter.GetDataByCategory(category);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
