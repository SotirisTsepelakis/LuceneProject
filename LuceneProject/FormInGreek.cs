using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuceneProject
{
    public partial class FormInGreek : Form
    {
        int rInt;

        public FormInGreek(int rInt)
        {
            InitializeComponent();
            this.rInt = rInt;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void articleTableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
        }

        private void toolStripSignInButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void toolStripRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void FormInGreek_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = Properties.Settings.Default.CyclopediaBaseConnectionString1
            };
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand("SELECT content FROM Media WHERE ID=?", con);
            cmd2.Parameters.AddWithValue("ID", rInt);

            try
            {
                String content = (String)cmd2.ExecuteScalar();
                richTextBox1.Text = content;
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
