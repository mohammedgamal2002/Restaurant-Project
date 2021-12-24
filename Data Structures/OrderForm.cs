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
    public partial class OrderForm : Form
    {
        public static DynamicArray<Order> orderList = new DynamicArray<Order>();
        int totalPrice;
        public OrderForm()
        {
            InitializeComponent();
        }
        public OrderForm(string name,int price,string type,string picture)
        {
            InitializeComponent();

            orderList.Add(new Order(name, price, type, picture));

        }



        private void ShowOrder()
        {
            foreach (Order order in orderList)
            {
                Panel panel = new Panel();
                panel.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
                panel.Size = new System.Drawing.Size(240, 205);


                Label orderName = new Label();
                orderName.Size = new Size(240, 29);
                orderName.Dock = DockStyle.Bottom;
                orderName.ForeColor = Color.FromArgb(214, 155, 15);
                orderName.Text = order.orderName;
                orderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                orderName.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                orderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                orderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.BackColor = Color.White;
                picture.LoadAsync(order.orderPictureURL);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                //picture.Click += new System.EventHandler(Food_Click);

                panel.Controls.Add(orderName);
                panel.Controls.Add(picture);


                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void GetPrice()
        {
            totalPrice = 0;
            foreach(Order order in orderList )
            {
                totalPrice += order.orderPrice;
            }
        }
        private void orderForm_Load(object sender, EventArgs e)
        {
            ShowOrder();

        }

        public class Order
        {
            public string orderName { get; set; }
            public string orderType { get; set; }
            public int orderPrice { get; set; }
            public string orderPictureURL;

            public Order(string orderName,int orderprice, string orderType, string orderPictureURL)
            {
                this.orderName = orderName;
                this.orderPrice = orderprice;
                this.orderType = orderType;
                this.orderPictureURL = orderPictureURL;
            }

        }

        private void totalPricebtn_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Enter(object sender, EventArgs e)
        {
            GetPrice();
            label1.Text = totalPrice.ToString();

        }
    }
}
