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
    public partial class AdminForm : Form
    {
        string img;
        string Type;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || priceTextBox.Text == "" || descriptionTextBox.Text == "")

            if (nameTextBox.Text == "") {
                MessageBox.Show("Enter a name");
            }
            if (priceTextBox.Text == "")
            {
                MessageBox.Show("Enter a price");

            }
            if (descriptionTextBox.Text == "")
            {
                MessageBox.Show("Enter a description");
            }
            if (img == null)
            {
                MessageBox.Show("Choose an image");

            }
            else
            {
                try
                {
                    if (Type == "Food")
                    {
                        FoodForm.AddFood(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img);
                        MessageBox.Show("Added!");
                    }
                    else if (Type == "Drinks")
                    {
                        DrinksForm.AddDrinks(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img);
                        MessageBox.Show("Added!");
                    }

                    else if (Type == "Desserts")
                    {
                        DessertForm.AddDessert(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img);
                        MessageBox.Show("Added!");
                    }
                    else
                        MessageBox.Show("Choose a type");
                }
                catch (System.FormatException)
                {

                    MessageBox.Show("Error : Invalid inputs");
                }


            }



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FoodForm.SaveFoodMenu();
            DrinksForm.SaveDrinksMenu();
            DessertForm.SaveDessertMenu();
        }


        private void AddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = ofd.FileName;
                newimage.LoadAsync(img);
            }

        }

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            Type = "Food";
            
        }

        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            Type = "Drinks";

        }

        private void AddDessertButton_Click(object sender, EventArgs e)
        {
            Type = "Desserts";

        }
    }
}
