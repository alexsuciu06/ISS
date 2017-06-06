using CMS.Controlers;
using CMS.Controllers;
using CMS.Validations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CMS
{
    public partial class Register : Form
    {
        private MainClientController reg_controller;
        public Register(MainClientController c)
        {
            reg_controller = c;
            InitializeComponent();
            RegisterWatermark();
        }

        #region watermark
        private void RegisterWatermark()
        {
            UsernameTextbox.ForeColor = SystemColors.GrayText;
            UsernameTextbox.Text = "Please Enter Your Username";

            FirstNameTextBox.ForeColor = SystemColors.GrayText;
            FirstNameTextBox.Text = "Please Enter Your first name";
            LastNameTextBox.ForeColor = SystemColors.GrayText;
            LastNameTextBox.Text = "Please Enter Your last name";
            AffilationTextBox.ForeColor = SystemColors.GrayText;
            AffilationTextBox.Text = "Please Enter Your affilation";

            PasswordTextbox.ForeColor = SystemColors.GrayText;
            PasswordTextbox.Text = "Please Enter Your Password";
            ConfirmPasswordTextBox.ForeColor = SystemColors.GrayText;
            ConfirmPasswordTextBox.Text = "Please Confirm Your Password";
            EmailTextBox.ForeColor = SystemColors.GrayText;
            EmailTextBox.Text = "Please Enter Your Email";

            this.UsernameTextbox.Leave += new System.EventHandler(this.UsernameTextbox_Leave);
            this.UsernameTextbox.Enter += new System.EventHandler(this.UsernameTextbox_Enter);

            this.FirstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
            this.FirstNameTextBox.Enter += new System.EventHandler(this.FirstNameTextBox_Enter);
            this.LastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
            this.LastNameTextBox.Enter += new System.EventHandler(this.LastNameTextBox_Enter);
            this.AffilationTextBox.Leave += new System.EventHandler(this.AffilationTextBox_Leave);
            this.AffilationTextBox.Enter += new System.EventHandler(this.AffilationTextBox_Enter);

            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.ConfirmPasswordTextBox.Leave += new System.EventHandler(this.ConfirmPasswordTextBox_Leave);
            this.ConfirmPasswordTextBox.Enter += new System.EventHandler(this.ConfirmPasswordTextBox_Enter);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            this.EmailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length == 0)
            {
                FirstNameTextBox.Text = "Please Enter Your first name";
                FirstNameTextBox.ForeColor = SystemColors.GrayText;
            }
        }
        private void FirstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "Please Enter Your Username")
            {
                FirstNameTextBox.Text = "";
                FirstNameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length == 0)
            {
                LastNameTextBox.Text = "Please Enter Your last name";
                LastNameTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void LastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text == "Please Enter Your last name")
            {
                LastNameTextBox.Text = "";
                LastNameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void AffilationTextBox_Leave(object sender, EventArgs e)
        {
            if (AffilationTextBox.Text.Length == 0)
            {
                AffilationTextBox.Text = "Please Enter Your Username";
                AffilationTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void AffilationTextBox_Enter(object sender, EventArgs e)
        {
            if (AffilationTextBox.Text == "Please Enter Your Username")
            {
                AffilationTextBox.Text = "";
                AffilationTextBox.ForeColor = SystemColors.WindowText;
            }
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
            string first_name = FirstNameTextBox.Text;
            string last_name = LastNameTextBox.Text;
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
                validation.validateExists(username,first_name,last_name,affilation,role);

                //trimitere la controller datele validate
                reg_controller.register(first_name, last_name, affilation, username, password, email, role);
                ValidationWindow validationWindow = new ValidationWindow(email, reg_controller);
                validationWindow.Show();
                this.Hide();
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
