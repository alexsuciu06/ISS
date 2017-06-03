using CMS.Controllers;
<<<<<<< Updated upstream
=======
using CMS.Validations;
>>>>>>> Stashed changes
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CMS
{
    public partial class LoginWindow : Form
    {
        Register reg = null;
        LoginChooseEditionWindow
        public MainClientController ctr;

        public LoginWindow(MainClientController ctr)
        {
            InitializeComponent();
            LoginWatermark();
            this.ctr = ctr;
        }

        private void LoginWatermark()
        {
            UsernameTextbox.ForeColor = SystemColors.GrayText;
            UsernameTextbox.Text = "Please Enter Your Username";
            PasswordTextbox.ForeColor = SystemColors.GrayText;
            PasswordTextbox.Text = "Please Enter Your Password";
            this.UsernameTextbox.Leave += new System.EventHandler(this.UsernameTextbox_Leave);
            this.UsernameTextbox.Enter += new System.EventHandler(this.UsernameTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //cnct.Deconectare();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                ctr.Login(
                    UsernameTextbox.Text,
                    PasswordTextbox.Text,
                    roleComboBox.Text
                 );
                this.Hide();
            } catch ( DataException ex )
            {
                MessageBox.Show(ex.Message, "Can't log you in!", MessageBoxButtons.OK);
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool gasit = false;
            foreach (Form frm in fc)
            {
                if (frm.Equals(reg))
                    gasit = true;
            }
            if (gasit == false)
                reg = null;
            if (reg != null)
            {
                reg.Close();
                this.reg = new Register(ctr);
                reg.Show();
            }
            else
            {
                this.reg = new Register(ctr);
                reg.Show();
            }
        }
    }
}
