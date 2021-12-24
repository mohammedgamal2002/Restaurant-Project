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
                }
            }
        }
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            userIcon.IconColor = Color.Black;



        }
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            userIcon.IconColor = Color.FromArgb(204, 156, 35);


        }



        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordIcon.IconColor = Color.Black;
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Unlock;

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordIcon.IconColor = Color.FromArgb(204, 156, 35);
            passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;


        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(46, 45, 45);
            panel1.BackColor = Color.FromArgb(204, 156, 35);
        }
    }
}
