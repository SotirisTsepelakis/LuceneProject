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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("Fields must not be empty");
            }
            else
            {
                OleDbConnection con = new OleDbConnection
                {
                    ConnectionString = Properties.Settings.Default.CyclopediaBaseConnectionString1
                };
                con.Open();
                string username = textBox1.Text;
                string password = textBox2.Text;
                string email = textBox3.Text;

                OleDbCommand cmd = new OleDbCommand("Insert into Users (Username, [Password], Email) values ('" + username + "','" + password + "','" + email + "')", con);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register Success!");
                    this.Close();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
