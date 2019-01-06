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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
