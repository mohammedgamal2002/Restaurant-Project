namespace Data_Structures
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.passwordIcon);
            this.panel1.Controls.Add(this.userIcon);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(32, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 368);
            this.panel1.TabIndex = 0;
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.passwordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(156)))), ((int)(((byte)(35)))));
            this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(156)))), ((int)(((byte)(35)))));
            this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.passwordIcon.IconSize = 27;
            this.passwordIcon.Location = new System.Drawing.Point(63, 174);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(27, 30);
            this.passwordIcon.TabIndex = 6;
            this.passwordIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.userIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(156)))), ((int)(((byte)(35)))));
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(156)))), ((int)(((byte)(35)))));
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 27;
            this.userIcon.Location = new System.Drawing.Point(63, 116);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(27, 30);
            this.userIcon.TabIndex = 5;
            this.userIcon.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(120, 184);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(141, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(120, 126);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(141, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Location = new System.Drawing.Point(120, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 25);
            this.panel2.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.BackColor = System.Drawing.Color.Silver;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(0, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(97, 25);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(411, 480);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginButton;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private FontAwesome.Sharp.IconPictureBox userIcon;
    }
}