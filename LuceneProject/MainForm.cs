﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
using LuceneProject.DatabaseDataSetTableAdapters;
using System.Data.OleDb;
using System.Drawing.Printing;

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
        public static string staticUname;
        private int lowerBound = 1, upperBound, rInt;

        public MainForm()
        {
            InitializeComponent();
            /* using (Indexer1 indexer = new Indexer1())
             {
               indexer.IndexDirectory = "Index";
                indexer.DataDirectory = "Data";
                  indexer.Setup();

                  indexer.Index();
             }
             Searcher1 searcher = new Searcher1();

             searcher.Search(indexer.IndexDirectory, "barcelona");

             Console.WriteLine();
             */
            /*  string indexDir = @"C:\Users\Stratos\source\repos\SotirisTsepelakis\LuceneProject\LuceneProject\bin\Debug\Index";
              using (Indexer1 indexer = new Indexer1())
              {
                  indexer.IndexDirectory = indexDir;
                  indexer.DataDirectory = @"C:\Users\Stratos\source\repos\SotirisTsepelakis\LuceneProject\LuceneProject\bin\Debug\Index\Data";
                  indexer.Setup();

                  indexer.Index();
              }

              Searcher1 searcher = new Searcher1();

              searcher.Search(indexDir,"barcelona");
              */
        }

        private void greekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInGreek form = new FormInGreek(rInt);
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

            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = Properties.Settings.Default.CyclopediaBaseConnectionString1
            };
            con.Open();
            OleDbCommand check_title = new OleDbCommand("SELECT COUNT(*) FROM Lemma WHERE title ='" + textBox1.Text + "'", con);
            check_title.Parameters.AddWithValue("@title", textBox1.Text);
            int TitleExist = (int)check_title.ExecuteScalar();

            if (TitleExist > 0)
            {
                MessageBox.Show("Article already exists");
            }
            else
            {
                lemmaTableAdapter.Insert(title);
                lemmaCategoryTableAdapter.Insert(category, title);
                mediaTableAdapter.Insert("doc", content);

                lemmaMediaTableAdapter.Insert(1, title);
            }
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

            favotiteTableAdapter.Insert(title, staticUname);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to export ?";
            const string caption = "Export";
            DialogResult index = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (index == DialogResult.No)
            {

            }
            System.IO.File.WriteAllLines(@"C:\Users\Sotiris\Desktop\LuceneProject\LuceneProject\bin\Debug\Index\Data\" + textBox1.Text + ".doc", richTextBox2.Lines);
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
                toolStripLabel2.Font = new Font("Arial", 8, FontStyle.Bold);

                setUsername(form.getUsernameToStore());
                staticUname = form.getUsernameToStore();

                FavoriteButton.Visible = true;
                showFavoritesButton.Visible = true;
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
            dataGridView1.Visible = true;
            dataGridView1.DataSource = lemmaCategoryTableAdapter.GetDataByCategory(category);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void showFavoritesButton_Click(object sender, EventArgs e)
        {
            Favorites f = new Favorites();
            f.Show();
        }

        private void titleSearchbutton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Type something first!!");
                return;
            }

            dataGridView2.Visible = true;
            dataGridView2.DataSource = lemmaTableAdapter.GetDataByTitleAndContent(textBox2.Text);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void keywordSearchbutton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Type something first!!");
                return;
            }

            string indexDir = @"C:\Users\Sotiris\Desktop\LuceneProject\LuceneProject\bin\Debug\Index";
            using (Indexer1 indexer = new Indexer1())
            {
                indexer.IndexDirectory = indexDir;
                indexer.DataDirectory = @"C:\Users\Sotiris\Desktop\LuceneProject\LuceneProject\bin\Debug\Index\Data";
                indexer.Setup();

                indexer.Index();
            }

            Searcher1 searcher = new Searcher1();
            searcher.Search(indexDir, textBox2.Text);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Search something first to print it!!");
                return;
            }
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(richTextBox2.Text);
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPrint.Print();
            }
        }

        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(richTextBox2.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.richTextBox2.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }
        }

        private void PrintPdf_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Search something first to print it!!");
                return;
            }

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox2.Text, new Font("Time New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = Properties.Settings.Default.CyclopediaBaseConnectionString1
            };
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Lemma", con);

            try
            {
                upperBound = (int)cmd.ExecuteScalar();
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                con.Close();
            }

            Random r = new Random();
            rInt = r.Next(lowerBound, upperBound + 1);
            Console.Write(rInt);

            con.Open();
            OleDbCommand cmd2 = new OleDbCommand("SELECT content FROM Media WHERE ID=?", con);
            cmd2.Parameters.AddWithValue("ID", rInt);

            OleDbCommand cmd3 = new OleDbCommand("SELECT LemmaTitle FROM LemmaMedia WHERE MediaID=?",con);
            cmd3.Parameters.AddWithValue("MediaID",rInt);

            try
            {
                String content = (String)cmd2.ExecuteScalar();
                richTextBox1.Text = content;

                String title = (String)cmd3.ExecuteScalar();
                titleLabel.Text = title;
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                con.Close();
            }

            String date = DateTime.Now.ToString("dd.MM.yyy");
            dayLabel.Text = date.ToString();

            //future work to draw from an API
            onThisDayRichTextBox.Text =
                "\n475 – Basiliscus became Byzantine Emperor after Zeno was forced to flee Constantinople." +
                "\n1857 – A 7.9 Mw earthquake ruptured part of the San Andreas Fault in California and was felt as far east as Las Vegas." +
                "\n1917 – First World War: Troops of the British Empire defeated Ottoman forces at the Battle of Rafa on the Sinai–Palestine border in present - day Rafah." +
                "\n1981 – U.S.Representative Raymond Lederer(pictured) was convicted of bribery and conspiracy for his role in the Abscam scandal, but continued to serve his term for three more months." +
                "\n1992 – Radio astronomers Aleksander Wolszczan and Dale Frail announced the discovery of two planets orbiting the pulsar PSR B1257 + 12, the first definitive detection of exoplanets.";


            //fill treeview dynamically from db
            DataTable dt = new DataTable();
            OleDbCommand cmd4 = new OleDbCommand("SELECT * FROM Category", con);
            con.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd4);
            da.Fill(dt);

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode
                    {
                        Text = (string)row["CategoryName"]
                    };
                    treeView1.Nodes.Add(node);
                }
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
