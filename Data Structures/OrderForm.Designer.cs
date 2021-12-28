
namespace Data_Structures
{
    partial class OrderForm
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
            this.delieveryPanel = new System.Windows.Forms.Panel();
            this.deliveryIcon = new FontAwesome.Sharp.IconPictureBox();
            this.deliveringTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delieveryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.pricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // delieveryPanel
            // 
            this.delieveryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delieveryPanel.BackColor = System.Drawing.Color.White;
            this.delieveryPanel.Controls.Add(this.deliveryIcon);
            this.delieveryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delieveryPanel.Location = new System.Drawing.Point(0, 354);
            this.delieveryPanel.Name = "delieveryPanel";
            this.delieveryPanel.Size = new System.Drawing.Size(665, 57);
            this.delieveryPanel.TabIndex = 0;
            // 
            // deliveryIcon
            // 
            this.deliveryIcon.BackColor = System.Drawing.Color.White;
            this.deliveryIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.deliveryIcon.IconChar = FontAwesome.Sharp.IconChar.Biking;
            this.deliveryIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.deliveryIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deliveryIcon.IconSize = 55;
            this.deliveryIcon.Location = new System.Drawing.Point(0, 4);
            this.deliveryIcon.Name = "deliveryIcon";
            this.deliveryIcon.Size = new System.Drawing.Size(55, 55);
            this.deliveryIcon.TabIndex = 0;
            this.deliveryIcon.TabStop = false;
            // 
            // deliveringTimer
            // 
            this.deliveringTimer.Tick += new System.EventHandler(this.deliveringTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pricePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 354);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(587, 354);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // pricePanel
            // 
            this.pricePanel.BackColor = System.Drawing.Color.White;
            this.pricePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pricePanel.Controls.Add(this.label2);
            this.pricePanel.Controls.Add(this.label1);
            this.pricePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pricePanel.Location = new System.Drawing.Point(587, 0);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(78, 354);
            this.pricePanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delieveryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            this.VisibleChanged += new System.EventHandler(this.OrderForm_VisibleChanged);
            this.delieveryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pricePanel.ResumeLayout(false);
            this.pricePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel delieveryPanel;
        private FontAwesome.Sharp.IconPictureBox deliveryIcon;
        private System.Windows.Forms.Timer deliveringTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pricePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}