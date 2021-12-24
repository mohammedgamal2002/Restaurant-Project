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

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (menuType.Text == "Food")
                {
                    FoodForm.AddFood(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img);
                    MessageBox.Show("Added!");
                }
                else if (menuType.Text == "Drinks")
                {
                    DrinksForm.AddDrinks(nameTextBox.Text, descriptionTextBox.Text, (int.Parse(priceTextBox.Text)), img);
                    MessageBox.Show("Added!");
                }

                else if (menuType.Text == "Desserts")
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

        //private void textBox2_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //       img = ofd.FileName;
        //    }
        //}

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FoodForm.SaveFoodMenu();
            DrinksForm.SaveDrinksMenu();
            DessertForm.SaveDessertMenu();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgTextBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = ofd.FileName;
                newimage.LoadAsync(img);
            }

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menuType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
