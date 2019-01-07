namespace LuceneProject
{
    partial class FormInGreek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInGreek));
            this.basicMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripDropDownLanguageButto = new System.Windows.Forms.ToolStripDropDownButton();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRegisterButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSignInButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLogoLabel = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.articleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.FavoriteButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cyclopediaBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoritesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basicMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.articleTableLayoutPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyclopediaBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basicMenuStrip
            // 
            this.basicMenuStrip.AutoSize = false;
            this.basicMenuStrip.BackColor = System.Drawing.SystemColors.Info;
            this.basicMenuStrip.ImageScalingSize = new System.Drawing.Size(50, 35);
            this.basicMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownLanguageButto,
            this.toolStripRegisterButton,
            this.toolStripLabel2,
            this.toolStripSignInButton,
            this.toolStripLogoLabel});
            this.basicMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.basicMenuStrip.Name = "basicMenuStrip";
            this.basicMenuStrip.Size = new System.Drawing.Size(960, 40);
            this.basicMenuStrip.TabIndex = 4;
            // 
            // toolStripDropDownLanguageButto
            // 
            this.toolStripDropDownLanguageButto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownLanguageButto.AutoSize = false;
            this.toolStripDropDownLanguageButto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownLanguageButto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem});
            this.toolStripDropDownLanguageButto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownLanguageButto.Image")));
            this.toolStripDropDownLanguageButto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownLanguageButto.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.toolStripDropDownLanguageButto.Name = "toolStripDropDownLanguageButto";
            this.toolStripDropDownLanguageButto.Size = new System.Drawing.Size(50, 30);
            this.toolStripDropDownLanguageButto.Text = "toolStripDropDownButton1";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("englishToolStripMenuItem.Image")));
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // toolStripRegisterButton
            // 
            this.toolStripRegisterButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripRegisterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRegisterButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripRegisterButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRegisterButton.Image")));
            this.toolStripRegisterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRegisterButton.Name = "toolStripRegisterButton";
            this.toolStripRegisterButton.Size = new System.Drawing.Size(188, 33);
            this.toolStripRegisterButton.Text = "Δημιουργία Λογαριασμού";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(18, 33);
            this.toolStripLabel2.Text = "ή";
            // 
            // toolStripSignInButton
            // 
            this.toolStripSignInButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSignInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSignInButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripSignInButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSignInButton.Image")));
            this.toolStripSignInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSignInButton.Name = "toolStripSignInButton";
            this.toolStripSignInButton.Size = new System.Drawing.Size(68, 33);
            this.toolStripSignInButton.Text = "Είσοδος";
            // 
            // toolStripLogoLabel
            // 
            this.toolStripLogoLabel.AutoSize = false;
            this.toolStripLogoLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLogoLabel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLogoLabel.Image")));
            this.toolStripLogoLabel.Name = "toolStripLogoLabel";
            this.toolStripLogoLabel.Size = new System.Drawing.Size(50, 40);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 467);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.articleTableLayoutPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Αρχική Σελίδα";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // articleTableLayoutPanel
            // 
            this.articleTableLayoutPanel.ColumnCount = 2;
            this.articleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.articleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.articleTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.articleTableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.articleTableLayoutPanel.Controls.Add(this.richTextBox1, 0, 1);
            this.articleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articleTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.articleTableLayoutPanel.Name = "articleTableLayoutPanel";
            this.articleTableLayoutPanel.RowCount = 2;
            this.articleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.886251F));
            this.articleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.11375F));
            this.articleTableLayoutPanel.Size = new System.Drawing.Size(946, 432);
            this.articleTableLayoutPanel.TabIndex = 0;
            this.articleTableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.articleTableLayoutPanel_CellPaint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Προτεινόμενο άρθρο της ημέρας";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(476, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Σαν σήμερα";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(467, 401);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.FavoriteButton);
            this.tabPage2.Controls.Add(this.ExportButton);
            this.tabPage2.Controls.Add(this.SaveButton);
            this.tabPage2.Controls.Add(this.SearchButton);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Αναζήτηση";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "reere",
            "gege"});
            this.comboBox1.Location = new System.Drawing.Point(322, 374);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(91, 161);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(429, 182);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "";
            // 
            // FavoriteButton
            // 
            this.FavoriteButton.Location = new System.Drawing.Point(91, 374);
            this.FavoriteButton.Margin = new System.Windows.Forms.Padding(4);
            this.FavoriteButton.Name = "FavoriteButton";
            this.FavoriteButton.Size = new System.Drawing.Size(100, 28);
            this.FavoriteButton.TabIndex = 25;
            this.FavoriteButton.Text = "Αγαπημένο";
            this.FavoriteButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(216, 101);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(100, 28);
            this.ExportButton.TabIndex = 24;
            this.ExportButton.Text = "Εξαγωγή";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(91, 101);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Αποθήκευση";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(420, 43);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 28);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Αναζήτηση";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 21;
            // 
            // cyclopediaBaseDataSetBindingSource
            //
            this.cyclopediaBaseDataSetBindingSource.Position = 0;
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataMember = "Articles";
            //
            // FormInGreek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.basicMenuStrip);
            this.Name = "FormInGreek";
            this.Text = "Cyclopedia";
            this.basicMenuStrip.ResumeLayout(false);
            this.basicMenuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.articleTableLayoutPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyclopediaBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip basicMenuStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownLanguageButto;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripRegisterButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripSignInButton;
        private System.Windows.Forms.ToolStripLabel toolStripLogoLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel articleTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource cyclopediaBaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private System.Windows.Forms.BindingSource favoritesBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button FavoriteButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}