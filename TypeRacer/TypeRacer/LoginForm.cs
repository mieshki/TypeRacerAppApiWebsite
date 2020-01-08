using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    public partial class LoginForm : Form
    {
        public static string actualUsername { get; set; }
        public static string actualPassword { get; set; }

        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            actualUsername = txtLogin.Text;
            actualPassword = txtPassword.Text;

            try
            {
                ChooseRaceLevel chooseRaceLevel = new ChooseRaceLevel(txtLogin.Text);

                string url = ApiRequest.url + "api/account/login";
                string parameters = "{\"Username\":\"" + txtLogin.Text + "\",\"Password\":\"" + txtPassword.Text + "\"}";

                string result = ApiRequest.POST_WithResponse(url, parameters);
                if (result == "true")
                {
                    chooseRaceLevel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account doesn't exist, create one");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server is not respoding");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //enter proper link, because depending on your computer port may change
            System.Diagnostics.Process.Start(ApiRequest.url + "Register");
        }
    }
}
