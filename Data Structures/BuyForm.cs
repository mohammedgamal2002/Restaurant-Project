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
        public BuyForm(string name, string type, int price)
        {

            InitializeComponent();
            this.name = name;
            this.type = type;
            this.price = price;
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
    }
}
