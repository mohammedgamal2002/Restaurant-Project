using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures
{
    public partial class DrinksForm : Form
    {

        public static DynamicArray<Drinks> drinksList = new DynamicArray<Drinks>();

        public DrinksForm()
        {
            InitializeComponent();
        }


        private void ShowDrinks()
        {
            foreach (Drinks drinks in drinksList)
            {
                Panel panel = new Panel();
                panel.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
                panel.Size = new System.Drawing.Size(240, 205);


                Label drinksName = new Label();
                drinksName.Size = new Size(240, 29);
                drinksName.Dock = DockStyle.Bottom;
                drinksName.ForeColor = Color.FromArgb(214, 155, 15);
                drinksName.Text = drinks.drinksName;
                drinksName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                drinksName.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                drinksName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                drinksName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.BackColor = Color.White;
                picture.LoadAsync(drinks.drinksPic);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new System.EventHandler(drinks_Click);

                panel.Controls.Add(drinksName);
                panel.Controls.Add(picture);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void drinks_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            int index = picture.Parent.TabIndex;
            string name = drinksList[index].drinksName;
            string type = drinksList[index].drinksType;
            int price = drinksList[index].drinksPrice;
            string pictureURL = drinksList[index].drinksPic;
            BuyForm buyForm = new BuyForm(name, type, price, pictureURL);
            buyForm.Show();
        }

        public static void SaveDrinksMenu()
        {
            using (var MenuWriter = new StreamWriter("Drinks_Menu.txt", false))
            {
                foreach (Drinks drinks in drinksList)
                {
                    MenuWriter.WriteLine(drinks.drinksName);
                    MenuWriter.WriteLine(drinks.drinksType);
                    MenuWriter.WriteLine(drinks.drinksPrice);
                    MenuWriter.WriteLine(drinks.drinksPic);
                }
            }
        }
        public static void LoadDrinksMenu()
        {
            try
            {
                using (var MenuReader = new StreamReader("Drinks_Menu.txt"))
                {
                    string drinksName;
                    string drinksType;
                    int price;
                    string drinksPic;
                    drinksName = MenuReader.ReadLine();
                    while (drinksName != null)
                    {
                        drinksType = MenuReader.ReadLine();
                        price = int.Parse(MenuReader.ReadLine());
                        drinksPic = MenuReader.ReadLine();

                        drinksList.Add(new Drinks(drinksName, drinksType, price, drinksPic));

                        drinksName = MenuReader.ReadLine();

                    }
                }
            }
            catch (FileNotFoundException)
            {

                using (var MenuWriter = new StreamWriter("Drinks_Menu.txt", false)) { }
            }
        }

        public static void AddDrinks(string name, string type, int price ,string drinksPic)
        {
            drinksList.Add(new Drinks(name, type, price, drinksPic));


        }

        private void drinksForm_Load(object sender, EventArgs e)
        {
            ShowDrinks();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
    public class Drinks
    {
        public string drinksName { get; set; }
        public string drinksType { get; set; }
        public int drinksPrice { get; set; }
        public string drinksPic;
        public Drinks(string drinksName, string drinksType, int drinksPrice , string drinksPic)
        {
            this.drinksName = drinksName;
            this.drinksType = drinksType;
            this.drinksPrice = drinksPrice;
            this.drinksPic = drinksPic;
        }
    }
}
