using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BLL;
using SMS.Models;

namespace SMS.WinApp
{
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager manager = new UserManager();
                User user = new User();

                user.Name = userNameTextBox.Text;
                user.Password = passwordTextBox.Text;

                if (manager.GetUser(user))
                {
                    Utility.UserName = userNameTextBox.Text;
                    //progressBar1.Show();
                    //timer.Start();
                    IndexUI index = new IndexUI();
                    this.Hide();
                    index.Show();
                }
                else
                {
                    incorrecMsgtLabel.Text = "User name or password doesn't matched!";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            incorrecMsgtLabel.Text = "";
        }
        

        private void loginButton_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.DarkRed;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Teal;
        }
    }
}
