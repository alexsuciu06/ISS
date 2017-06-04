using CMS.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class ValidationWindow : Form
    {
        private string email;
        MainClientController ctr;
        public ValidationWindow(string email,MainClientController c)
        {
            this.email = email;
            this.ctr = c;
            InitializeComponent();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            string key = textBoxKey.Text;
            try {
                ctr.validation(email, key);
                ChooseEdition chooseEdition = new ChooseEdition(ctr);
                chooseEdition.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
