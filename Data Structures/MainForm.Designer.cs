﻿namespace Data_Structures
{
    partial class MainForm
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
            this.drinksFormButton = new FontAwesome.Sharp.IconButton();
            this.dessertMenu = new FontAwesome.Sharp.IconButton();
            this.FoodMenu = new FontAwesome.Sharp.IconButton();
            this.ordersButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.shadowPanel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.childFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.drinksFormButton);
            this.panel1.Controls.Add(this.dessertMenu);
            this.panel1.Controls.Add(this.FoodMenu);
            this.panel1.Controls.Add(this.ordersButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 450);
            this.panel1.TabIndex = 0;
            // 
            // drinksFormButton
            // 
            this.drinksFormButton.BackColor = System.Drawing.Color.White;
            this.drinksFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.drinksFormButton.FlatAppearance.BorderSize = 0;
            this.drinksFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinksFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(123)))), ((int)(((byte)(2)))));
            this.drinksFormButton.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.drinksFormButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.drinksFormButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.drinksFormButton.IconSize = 33;
            this.drinksFormButton.Location = new System.Drawing.Point(0, 251);
            this.drinksFormButton.Name = "drinksFormButton";
            this.drinksFormButton.Size = new System.Drawing.Size(119, 53);
            this.drinksFormButton.TabIndex = 3;
            this.drinksFormButton.Text = "Drinks";
            this.drinksFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.drinksFormButton.UseVisualStyleBackColor = false;
            this.drinksFormButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // dessertMenu
            // 
            this.dessertMenu.BackColor = System.Drawing.Color.White;
            this.dessertMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dessertMenu.FlatAppearance.BorderSize = 0;
            this.dessertMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dessertMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(123)))), ((int)(((byte)(2)))));
            this.dessertMenu.IconChar = FontAwesome.Sharp.IconChar.BirthdayCake;
            this.dessertMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.dessertMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dessertMenu.IconSize = 33;
            this.dessertMenu.Location = new System.Drawing.Point(0, 198);
            this.dessertMenu.Name = "dessertMenu";
            this.dessertMenu.Size = new System.Drawing.Size(119, 53);
            this.dessertMenu.TabIndex = 2;
            this.dessertMenu.Text = "Desserts";
            this.dessertMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dessertMenu.UseVisualStyleBackColor = false;
            this.dessertMenu.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // FoodMenu
            // 
            this.FoodMenu.BackColor = System.Drawing.Color.White;
            this.FoodMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodMenu.FlatAppearance.BorderSize = 0;
            this.FoodMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(123)))), ((int)(((byte)(2)))));
            this.FoodMenu.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.FoodMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.FoodMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FoodMenu.IconSize = 33;
            this.FoodMenu.Location = new System.Drawing.Point(0, 145);
            this.FoodMenu.Name = "FoodMenu";
            this.FoodMenu.Size = new System.Drawing.Size(119, 53);
            this.FoodMenu.TabIndex = 1;
            this.FoodMenu.Text = "Food";
            this.FoodMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FoodMenu.UseVisualStyleBackColor = false;
            this.FoodMenu.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.White;
            this.ordersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersButton.FlatAppearance.BorderSize = 0;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(123)))), ((int)(((byte)(2)))));
            this.ordersButton.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ordersButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ordersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ordersButton.IconSize = 33;
            this.ordersButton.Location = new System.Drawing.Point(0, 92);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(119, 53);
            this.ordersButton.TabIndex = 0;
            this.ordersButton.Text = "My Orders";
            this.ordersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.logoPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 92);
            this.panel3.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.White;
            this.logoPictureBox.Image = global::Data_Structures.Properties.Resources.cooking_g675e71e80_1280;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(92, 74);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.White;
            this.childFormPanel.Controls.Add(this.shadowPanel1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(119, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(681, 450);
            this.childFormPanel.TabIndex = 1;
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.shadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.shadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.Size = new System.Drawing.Size(2, 450);
            this.shadowPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel childFormPanel;
        private FontAwesome.Sharp.IconButton ordersButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel shadowPanel1;
        private FontAwesome.Sharp.IconButton drinksFormButton;
        private FontAwesome.Sharp.IconButton dessertMenu;
        private FontAwesome.Sharp.IconButton FoodMenu;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}

