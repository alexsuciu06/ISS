using CMS.Controlers;
using CMS.Validations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CMS
{
    public partial class Register : Form
    {
        private RegisterController reg_controller;
        public Register()
        {
            InitializeComponent();
            RegisterWatermark();
        }

        #region watermark
        private void RegisterWatermark()
        {
            UsernameTextbox.ForeColor = SystemColors.GrayText;
            UsernameTextbox.Text = "Please Enter Your Username";
            PasswordTextbox.ForeColor = SystemColors.GrayText;
            PasswordTextbox.Text = "Please Enter Your Password";
            ConfirmPasswordTextBox.ForeColor = SystemColors.GrayText;
            ConfirmPasswordTextBox.Text = "Please Confirm Your Password";
            EmailTextBox.ForeColor = SystemColors.GrayText;
            EmailTextBox.Text = "Please Enter Your Email";
            this.UsernameTextbox.Leave += new System.EventHandler(this.UsernameTextbox_Leave);
            this.UsernameTextbox.Enter += new System.EventHandler(this.UsernameTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.ConfirmPasswordTextBox.Leave += new System.EventHandler(this.ConfirmPasswordTextBox_Leave);
            this.ConfirmPasswordTextBox.Enter += new System.EventHandler(this.ConfirmPasswordTextBox_Enter);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            this.EmailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text.Length == 0)
            {
                UsernameTextbox.Text = "Please Enter Your Username";
                UsernameTextbox.ForeColor = SystemColors.GrayText;
            }
        }

        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "Please Enter Your Username")
            {
                UsernameTextbox.Text = "";
                UsernameTextbox.ForeColor = SystemColors.WindowText;
            }
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text.Length == 0)
            {
                PasswordTextbox.Text = "Please Enter Your Password";
                PasswordTextbox.ForeColor = SystemColors.GrayText;
                PasswordTextbox.PasswordChar = '\0';
            }
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "Please Enter Your Password")
            {
                PasswordTextbox.Text = "";
                PasswordTextbox.ForeColor = SystemColors.WindowText;
                PasswordTextbox.PasswordChar = '*';
            }
        }

        private void ConfirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.Text.Length == 0)
            {
                ConfirmPasswordTextBox.Text = "Please Confirm Your Password";
                ConfirmPasswordTextBox.ForeColor = SystemColors.GrayText;
                ConfirmPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void ConfirmPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.Text == "Please Confirm Your Password")
            {
                ConfirmPasswordTextBox.Text = "";
                ConfirmPasswordTextBox.ForeColor = SystemColors.WindowText;
                ConfirmPasswordTextBox.PasswordChar = '*';
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text.Length == 0)
            {
                EmailTextBox.Text = "Please Enter Your Email";
                EmailTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "Please Enter Your Email")
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = SystemColors.WindowText;
            }
        }
        #endregion

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string first_nume = FirstNameTextBox.Text;
            string last_nume = LastNameTextBox.Text;
            string affilation = AffilationTextBox.Text;
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;
            string confirm_password = ConfirmPasswordTextBox.Text;
            string email = EmailTextBox.Text;
            string role = comboBoxRole.Text;

            
            try
            {
                //validari pe date
                ValidationData validation = new ValidationData();
                validation.validateEmail(email);
                validation.validatePassword(password, confirm_password);
                validation.validateUsername(reg_controller.getServer(), username);

                //trimitere la controller datele validate
                reg_controller.register(first_nume, last_nume, affilation, username, password, email, role);
            }
            catch(DataException exp) {
                MessageBox.Show(exp.Message);
            }
                
            
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
