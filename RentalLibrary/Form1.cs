using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentalLibrary
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        Controller.UserController Controller = new Controller.UserController();

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Model.User Tmp = new Model.User();

            if (string.IsNullOrWhiteSpace(TextBoxUsername.Text))
            {
                MessageBox.Show("Enter a username!");
            }
            else if (string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {
                MessageBox.Show("Enter a password!");
            }
            try
            {
                Tmp.Username = TextBoxUsername.Text;
                Tmp.Password = TextBoxPassword.Text;

                Controller.RegUser(Tmp);

                MessageBox.Show("Registration Successfull!");
            }
            catch (SqlException Ex)
            {
                switch (Ex.Number)
                {
                    case 2627:
                        MessageBox.Show("This username is already taken.");
                        break;
                    case 8152:
                        MessageBox.Show("Username and/or password can be maximun of 20 characters");
                        break;
                    default: throw Ex;
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Model.User Tmp = new Model.User();

            if (string.IsNullOrWhiteSpace(TextBoxUsernameLogin.Text))
            {
                MessageBox.Show("Enter a username!");
            }
            else if (string.IsNullOrWhiteSpace(TextBoxPasswordLogin.Text))
            {
                MessageBox.Show("Enter a password!");
            }
            try
            {
                Tmp.Username = TextBoxUsernameLogin.Text;
                Tmp.Password = TextBoxPasswordLogin.Text;

                Controller.LoginUser(Tmp);

                //MessageBox.Show("Login Successfull!");
            }
            catch (SqlException Ex)
            {
                /*switch (Ex.Number)
                {
                    case 2627:
                        MessageBox.Show("This username is already taken.");
                        break;*/
            }
        }
    }
}
