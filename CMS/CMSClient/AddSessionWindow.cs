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
        CreateScheduleWindow _sender = null;

        public AddSessionWindow(MainClientController ctr, CreateScheduleWindow _sender)
        {
            InitializeComponent();
            this.ctr = ctr;
            this._sender = _sender;
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
            if (_sender != null)
            {
                _sender.RefreshSessions();
            } else
            {
                MessageBox.Show("Session added.");
            }
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoomForm = new AddRoomForm(ctr, this);
            addRoomForm.Show();
        }

        internal void UpdateRoomsList()
        {
            comboBoxRooms.DataSource = ctr.AllRooms();
            comboBoxRooms.DisplayMember = "RoomNr";
        }

        private void AddSessionWindow_Load(object sender, EventArgs e)
        {
            UpdateRoomsList();
        }
    }
}
