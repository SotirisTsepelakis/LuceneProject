namespace LuceneProject
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FavoriteButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cyclopediaBaseDataSet = new LuceneProject.CyclopediaBaseDataSet();
            this.cyclopediaBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articlesTableAdapter = new LuceneProject.CyclopediaBaseDataSetTableAdapters.ArticlesTableAdapter();
            this.favoritesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoritesTableAdapter = new LuceneProject.CyclopediaBaseDataSetTableAdapters.FavoritesTableAdapter();
            this.GoTo = new System.Windows.Forms.Button();
            this.Myfavs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cyclopediaBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclopediaBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arts‎ ",
            "Business‎ ",
            "Concepts‎",
            "Culture‎ ",
            "Education",
            "Entertainment‎",
            "Events‎ ",
            "Geography‎ ",
            "Health",
            "History‎",
            "Humanities‎ ",
            "Language‎",
            "Law‎",
            "Life‎ ",
            "Mathematics‎",
            "Nature‎",
            "People‎",
            "Philosophy‎",
            "Politics‎",
            "Reference‎ ",
            "Religion‎",
            "Science‎ ",
            "Society‎ ",
            "Sports‎",
            "Technology‎ ",
            "Universe‎ ",
            "World‎ "});
            this.comboBox1.Location = new System.Drawing.Point(405, 336);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(275, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 149);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // FavoriteButton
            // 
            this.FavoriteButton.Location = new System.Drawing.Point(275, 336);
            this.FavoriteButton.Name = "FavoriteButton";
            this.FavoriteButton.Size = new System.Drawing.Size(75, 23);
            this.FavoriteButton.TabIndex = 11;
            this.FavoriteButton.Text = "Favorite";
            this.FavoriteButton.UseVisualStyleBackColor = true;
            this.FavoriteButton.Click += new System.EventHandler(this.FavoriteButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(451, 133);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 10;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(275, 134);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(451, 91);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // cyclopediaBaseDataSet
            // 
            this.cyclopediaBaseDataSet.DataSetName = "CyclopediaBaseDataSet";
            this.cyclopediaBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cyclopediaBaseDataSetBindingSource
            // 
            this.cyclopediaBaseDataSetBindingSource.DataSource = this.cyclopediaBaseDataSet;
            this.cyclopediaBaseDataSetBindingSource.Position = 0;
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataMember = "Articles";
            this.articlesBindingSource.DataSource = this.cyclopediaBaseDataSet;
            // 
            // articlesTableAdapter
            // 
            this.articlesTableAdapter.ClearBeforeFill = true;
            // 
            // favoritesBindingSource
            // 
            this.favoritesBindingSource.DataMember = "Favorites";
            this.favoritesBindingSource.DataSource = this.cyclopediaBaseDataSet;
            // 
            // favoritesTableAdapter
            // 
            this.favoritesTableAdapter.ClearBeforeFill = true;
            // 
            // GoTo
            // 
            this.GoTo.Location = new System.Drawing.Point(672, 383);
            this.GoTo.Name = "GoTo";
            this.GoTo.Size = new System.Drawing.Size(75, 23);
            this.GoTo.TabIndex = 14;
            this.GoTo.Text = "GoTo";
            this.GoTo.UseVisualStyleBackColor = true;
            this.GoTo.Click += new System.EventHandler(this.GoTo_Click);
            // 
            // Myfavs
            // 
            this.Myfavs.Location = new System.Drawing.Point(672, 413);
            this.Myfavs.Name = "Myfavs";
            this.Myfavs.Size = new System.Drawing.Size(75, 23);
            this.Myfavs.TabIndex = 15;
            this.Myfavs.Text = "MyFavs";
            this.Myfavs.UseVisualStyleBackColor = true;
            this.Myfavs.Click += new System.EventHandler(this.Myfavs_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Myfavs);
            this.Controls.Add(this.GoTo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FavoriteButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cyclopediaBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclopediaBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button FavoriteButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource cyclopediaBaseDataSetBindingSource;
        private CyclopediaBaseDataSet cyclopediaBaseDataSet;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private CyclopediaBaseDataSetTableAdapters.ArticlesTableAdapter articlesTableAdapter;
        private System.Windows.Forms.BindingSource favoritesBindingSource;
        private CyclopediaBaseDataSetTableAdapters.FavoritesTableAdapter favoritesTableAdapter;
        private System.Windows.Forms.Button GoTo;
        private System.Windows.Forms.Button Myfavs;
    }
}