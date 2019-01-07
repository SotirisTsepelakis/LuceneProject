using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuceneProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection
            {
                ConnectionString = Properties.Settings.Default.CyclopediaBaseConnectionString2
            };
            con.Open();
            string username = textBox1.Text;
            string password = textBox2.Text;

            OleDbCommand cmd = new OleDbCommand("select Username,Password from Users where Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You logged in succesfully");
                this.Close();
            }
            else
                MessageBox.Show("Invalid Login please check username and password");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
