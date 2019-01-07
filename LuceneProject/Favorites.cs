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
    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();
        }

        private void ShowFavs_Click(object sender, EventArgs e)
        {
          //  FavoriteGridView.DataSource = favoritesTableAdapter1.GetDataByFav();
            FavoriteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
