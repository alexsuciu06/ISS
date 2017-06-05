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
    public partial class AddSessionWindow : Form
    {
        MainClientController ctr;

        public AddSessionWindow(MainClientController ctr)
        {
            InitializeComponent();
            this.ctr = ctr;
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            if (comboBoxRooms.Text == "")
            {
                MessageBox.Show("You must choose a room");
                return;
            }
            Room chosen = comboBoxRooms.SelectedItem as Room;
            User chair = ctr.GetUserByEmail(textBoxChairMail.Text);
            if (chair == null)
            {
                MessageBox.Show("The user with this email dows not exist.");
                return;
            }
            Session session = new Session(chosen, chair, ctr.CurrentEdition);
            ctr.AddSession(session);
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoomForm = new AddRoomForm(ctr);
            addRoomForm.Show();
        }

        private void AddSessionWindow_Load(object sender, EventArgs e)
        {
            comboBoxRooms.DataSource= ctr.AllRooms();
            comboBoxRooms.DisplayMember = "RoomNr";
        }
    }
}
