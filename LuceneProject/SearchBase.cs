using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuceneProject
{
    public partial class SearchBase : Form
    {
        public SearchBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string category = textBox1.Text;
            dataGridView1.DataSource = articlesTableAdapter.GetDataByCategory(category);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyclopediaBaseDataSet1.Articles' table. You can move, or remove it, as needed.
            this.articlesTableAdapter.Fill(this.cyclopediaBaseDataSet.Articles);
        }

        private void ShowFavs_Click(object sender, EventArgs e)
        {
            Favorites f = new Favorites();
            f.Show();
        }
    }
}
