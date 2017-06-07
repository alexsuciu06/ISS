using CMS.Controllers;
using Model;
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
    public partial class AddEditionWindow : Form
    {
        
        private Conference conference;

        private string editionName;
        private DateTime deadline;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private Edition edition;

        private MainClientController mcController;



        public AddEditionWindow(Conference conference, MainClientController mcController)
        {
            this.conference = conference;
            this.mcController = mcController;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InputData();
            AddEditionHandle();
        }


        private bool CheckEditionName()
        {
            return editionName == "" ? false : true;
        }

        private void InputData()
        {
            if(CheckEditionName())
                editionName = EditionNameTextBox.Text;

            deadline = new DateTime(1900, 1, 1);
            DateTime.TryParse(DeadlineTextBox.Text, out deadline);
            if (deadline.Year.Equals(1900))
            {
                MessageBox.Show("Time should be in DD/MM/YYYY HH:MM format!");
                return;
            }

            startDateTime = new DateTime(1900, 1, 1);
            DateTime.TryParse(StartTextBox.Text, out startDateTime);
            if (startDateTime.Year.Equals(1900))
            {
                MessageBox.Show("Time should be in DD/MM/YYYY HH:MM format!");
                return;
            }

            endDateTime = new DateTime(1900, 1, 1);
            DateTime.TryParse(EndsTextBox.Text, out endDateTime);
            if (endDateTime.Year.Equals(1900))
            {
                MessageBox.Show("Time should be in DD/MM/YYYY HH:MM format!");
                return;
            }
        }


        private void AddEditionHandle()
        {
            edition = new Edition(editionName, conference, DeadlineTextBox.Text, StartTextBox.Text, EndsTextBox.Text);
            mcController.AddEdition(edition);
        }


        


        



        private void AddEditionWindow_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
