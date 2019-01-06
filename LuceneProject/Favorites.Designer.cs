namespace LuceneProject
{
    partial class Favorites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FavoriteGridView = new System.Windows.Forms.DataGridView();
            this.ShowFavs = new System.Windows.Forms.Button();
            this.favoritesTableAdapter1 = new LuceneProject.CyclopediaBaseDataSetTableAdapters.FavoritesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FavoriteGridView
            // 
            this.FavoriteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FavoriteGridView.Location = new System.Drawing.Point(169, 123);
            this.FavoriteGridView.Name = "FavoriteGridView";
            this.FavoriteGridView.Size = new System.Drawing.Size(396, 253);
            this.FavoriteGridView.TabIndex = 0;
            // 
            // ShowFavs
            // 
            this.ShowFavs.Location = new System.Drawing.Point(1, 123);
            this.ShowFavs.Name = "ShowFavs";
            this.ShowFavs.Size = new System.Drawing.Size(75, 44);
            this.ShowFavs.TabIndex = 1;
            this.ShowFavs.Text = "ShowFavs";
            this.ShowFavs.UseVisualStyleBackColor = true;
            this.ShowFavs.Click += new System.EventHandler(this.ShowFavs_Click);
            // 
            // favoritesTableAdapter1
            // 
            this.favoritesTableAdapter1.ClearBeforeFill = true;
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowFavs);
            this.Controls.Add(this.FavoriteGridView);
            this.Name = "Favorites";
            this.Text = "Favorites";
            ((System.ComponentModel.ISupportInitialize)(this.FavoriteGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FavoriteGridView;
        private System.Windows.Forms.Button ShowFavs;
        private CyclopediaBaseDataSetTableAdapters.FavoritesTableAdapter favoritesTableAdapter1;
    }
}