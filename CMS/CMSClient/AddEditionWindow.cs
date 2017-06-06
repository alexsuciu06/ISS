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
        
        private string conferenceName = "";
        private string editionName = "";
        private Conference conference;
        private Edition edition;
        private MainClientController mcController;



        public AddEditionWindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

          
            AddEditionHandle();
            ConferenceNameTextBox.Text = "";
        }

        private void AddEditionHandle()
        {
            conferenceName = ConferenceNameTextBox.Text;
            editionName = EditionNameTextBox.Text;

            if (CheckConferenceName())
            {
                if (CheckEditionName())
                {
                    conference = new Conference(conferenceName);
                    edition = new Edition(editionName, conference);
                    mcController.AddConference(conference);
                    mcController.AddEdition(edition);
                }
                else
                {
                    MessageBox.Show("Introduceti numele Editiei!", "Warning!");
                }
            }
            else
            {
                MessageBox.Show("Introduceti numele Conferintei!", "Warning!");
            }
        }


        private bool CheckConferenceName()
        {
            return conferenceName == "" ? false : true;
        }


        private bool CheckEditionName()
        {
            return editionName == "" ? false : true;
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
