﻿using CMS.Controllers;
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
    public partial class AddRoomForm : Form
    {
        MainClientController ctr;
        AddSessionWindow sender;

        public AddRoomForm(MainClientController ctr, AddSessionWindow sender)
        {
            InitializeComponent();
            this.sender = sender;
            this.ctr = ctr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "" || this.textBox2.Text == "" )
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            int seats = -1;
            int.TryParse(textBox1.Text, out seats);
            if (seats.Equals(-1))
            {
                MessageBox.Show("Enter a valid number of seats!");
                return;
            }
            ctr.AddNewRoom(seats, textBox2.Text);
            MessageBox.Show("Room added");
            if (this.sender != null)
            {
                this.sender.UpdateRoomsList();
            } else
            {
                MessageBox.Show("Room added!");
                this.sender = new AddSessionWindow(ctr, null);
                this.sender.Show();
            }
        }
    }
}
