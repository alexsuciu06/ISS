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
    public partial class CreateScheduleWindow : Form
    {
        MainClientController ctr;
        Paper paper;

        public CreateScheduleWindow(Paper paper, MainClientController ctr)
        {
            InitializeComponent();
            this.ctr = ctr;
            this.paper = paper;
            if(paper == null)
            {
                this.chosenPaperLabel.Visible = false;
                this.btnAddPresentation.Visible = false;
            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            AddSessionWindow addSessionWin = new AddSessionWindow(ctr);
            addSessionWin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime pres_time = new DateTime(1900, 1, 1);
            DateTime.TryParse(textBox1.Text, out pres_time);
            if (pres_time.Year.Equals(1900))
            {
                MessageBox.Show("Time should be in DD/MM/YYYY HH:MM format!");
                return;
            }
            DateTime edition_start_time = DateTime.Parse(ctr.CurrentEdition.StartDateTime);
            DateTime edition_end_date = DateTime.Parse(ctr.CurrentEdition.EndDateTime);
            if (pres_time.CompareTo(edition_start_time) < 0 || pres_time.CompareTo(edition_end_date) > 0)
            {
                MessageBox.Show("The conference time is between " + edition_start_time.ToString()
                    + " and " + edition_end_date.ToString());
                return;
            }
            Presentation pres = new Presentation(paper, pres_time, listBox1.SelectedItem as Session);
            ctr.AddPresentation(pres);
        }

        private void CreateScheduleWindow_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = ctr.AllSessions();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                Session selected = listBox1.SelectedItems[0] as Session;
                dataGridView1.DataSource = ctr.GetPresentationsForSession(selected.IdSession);
            }
        }
    }
}
