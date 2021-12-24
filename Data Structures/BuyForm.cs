using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    public partial class BuyForm : Form
    {
       
        string name;
        string type;
        int price;
        string pictureURL;
        public BuyForm(string name, string type, int price,string pictureURL)
        {

            InitializeComponent();
            this.name = name;
            this.type = type;
            this.price = price;
            this.pictureURL = pictureURL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text += name;
            typeLabel.Text += type;
            priceLabel.Text += price;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Buy_Click(object sender, EventArgs e)
        {
            MainForm.orderForm.Update();
            OrderForm order = new OrderForm(name, price, type, pictureURL);

            this.Close();
        }
    }
}
