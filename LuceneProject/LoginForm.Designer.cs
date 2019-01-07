namespace LuceneProject
{
    partial class LoginForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(28, 115);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(28, 166);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(73, 17);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(82, 286);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 32);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(253, 286);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 22);
            this.textBox2.TabIndex = 5;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.promptLabel.Location = new System.Drawing.Point(41, 33);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(346, 18);
            this.promptLabel.TabIndex = 6;
            this.promptLabel.Text = "Please provide your username and password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 364);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label promptLabel;
    }
}