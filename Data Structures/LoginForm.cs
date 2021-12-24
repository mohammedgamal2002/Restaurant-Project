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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin")
            {
                if (passwordTextBox.Text == "admin")
                {
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Close();
                }
            }
        }
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            userIcon.IconColor = Color.Black;
            ChangeBackColor();



        }
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            userIcon.IconColor = Color.FromArgb(163, 120, 8);


        }



        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordIcon.IconColor = Color.Black;
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            ChangeBackColor();

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordIcon.IconColor = Color.FromArgb(163, 120, 8);
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;


        }
        private void ChangeBackColor() {
            this.BackColor = Color.FromArgb(46, 45, 45);
            loginPanel.BackColor = Color.FromArgb(230, 173, 30);
            loginButton.BackColor = Color.FromArgb(54, 53, 50);
            loginButton.ForeColor = Color.White;
        }
    }
}
