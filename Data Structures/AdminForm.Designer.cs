namespace Data_Structures
{
    partial class AdminForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddDessertButton = new System.Windows.Forms.Button();
            this.AddDrinkButton = new System.Windows.Forms.Button();
            this.AddFoodButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newimage = new System.Windows.Forms.PictureBox();
            this.LoadPicIcon = new FontAwesome.Sharp.IconPictureBox();
            this.AddImgButton = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPicIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(3, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(287, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Picture";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(367, 57);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(95, 29);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 46);
            this.priceTextBox.TabIndex = 8;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 228);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(447, 77);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(156, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 76);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(135, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 76);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add New Item";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddDessertButton);
            this.panel2.Controls.Add(this.AddDrinkButton);
            this.panel2.Controls.Add(this.AddFoodButton);
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 261);
            this.panel2.TabIndex = 13;
            // 
            // AddDessertButton
            // 
            this.AddDessertButton.BackgroundImage = global::Data_Structures.Properties.Resources._4869626_1431322447;
            this.AddDessertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddDessertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDessertButton.Location = new System.Drawing.Point(145, 126);
            this.AddDessertButton.Name = "AddDessertButton";
            this.AddDessertButton.Size = new System.Drawing.Size(145, 132);
            this.AddDessertButton.TabIndex = 2;
            this.AddDessertButton.UseVisualStyleBackColor = true;
            this.AddDessertButton.Click += new System.EventHandler(this.AddDessertButton_Click);
            // 
            // AddDrinkButton
            // 
            this.AddDrinkButton.BackgroundImage = global::Data_Structures.Properties.Resources._2019_6_17_19_29_26_907;
            this.AddDrinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddDrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDrinkButton.Location = new System.Drawing.Point(3, 126);
            this.AddDrinkButton.Name = "AddDrinkButton";
            this.AddDrinkButton.Size = new System.Drawing.Size(136, 132);
            this.AddDrinkButton.TabIndex = 1;
            this.AddDrinkButton.UseVisualStyleBackColor = true;
            this.AddDrinkButton.Click += new System.EventHandler(this.AddDrinkButton_Click);
            // 
            // AddFoodButton
            // 
            this.AddFoodButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFoodButton.BackgroundImage = global::Data_Structures.Properties.Resources._3295_1;
            this.AddFoodButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddFoodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFoodButton.Location = new System.Drawing.Point(3, 3);
            this.AddFoodButton.Name = "AddFoodButton";
            this.AddFoodButton.Size = new System.Drawing.Size(287, 117);
            this.AddFoodButton.TabIndex = 0;
            this.AddFoodButton.UseVisualStyleBackColor = true;
            this.AddFoodButton.Click += new System.EventHandler(this.AddFoodButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newimage);
            this.panel3.Controls.Add(this.LoadPicIcon);
            this.panel3.Controls.Add(this.AddImgButton);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.descriptionTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.priceTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(299, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 308);
            this.panel3.TabIndex = 14;
            // 
            // newimage
            // 
            this.newimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newimage.ErrorImage = null;
            this.newimage.InitialImage = null;
            this.newimage.Location = new System.Drawing.Point(369, 103);
            this.newimage.Name = "newimage";
            this.newimage.Size = new System.Drawing.Size(81, 50);
            this.newimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newimage.TabIndex = 15;
            this.newimage.TabStop = false;
            // 
            // LoadPicIcon
            // 
            this.LoadPicIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadPicIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadPicIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadPicIcon.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.LoadPicIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.LoadPicIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoadPicIcon.IconSize = 51;
            this.LoadPicIcon.Location = new System.Drawing.Point(301, 103);
            this.LoadPicIcon.Name = "LoadPicIcon";
            this.LoadPicIcon.Size = new System.Drawing.Size(62, 51);
            this.LoadPicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoadPicIcon.TabIndex = 14;
            this.LoadPicIcon.TabStop = false;
            // 
            // AddImgButton
            // 
            this.AddImgButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddImgButton.Location = new System.Drawing.Point(95, 102);
            this.AddImgButton.Name = "AddImgButton";
            this.AddImgButton.Size = new System.Drawing.Size(200, 51);
            this.AddImgButton.TabIndex = 13;
            this.AddImgButton.Text = "Add";
            this.AddImgButton.UseVisualStyleBackColor = false;
            this.AddImgButton.Click += new System.EventHandler(this.AddImg_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.ErrorImage = null;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 46;
            this.iconPictureBox1.InitialImage = null;
            this.iconPictureBox1.Location = new System.Drawing.Point(301, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 46);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.SaveButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 399);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(752, 57);
            this.panel4.TabIndex = 15;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameTextBox);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPicIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button AddImgButton;
        private System.Windows.Forms.PictureBox newimage;
        private System.Windows.Forms.Button AddDessertButton;
        private System.Windows.Forms.Button AddDrinkButton;
        private System.Windows.Forms.Button AddFoodButton;
        private FontAwesome.Sharp.IconPictureBox LoadPicIcon;
    }
}