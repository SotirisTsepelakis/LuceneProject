using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuceneProject.DatabaseDataSetTableAdapters;
namespace LuceneProject
{
    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();
        }

        FavotiteTableAdapter favotiteTableAdapter = new FavotiteTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        private string name1="user1";
        private string name2 = "user2";
    
        

        private void ShowFavs_Click(object sender, EventArgs e)
        {


          
            if (name1 == MainForm.staticUname)
            {
                FavoriteGridView.DataSource = favotiteTableAdapter.GetDataByUsername(name1);
                FavoriteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else if (name2 == MainForm.staticUname) { 
            FavoriteGridView.DataSource = favotiteTableAdapter.GetDataByUsername(name2);
            FavoriteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {

                FavoriteGridView.DataSource = favotiteTableAdapter.GetData();
                FavoriteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }
    
    }
}
