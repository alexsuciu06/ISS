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
    public partial class ChooseEdition : Form
    {
        private MainClientController ctr;

        public ChooseEdition(MainClientController ctr)
        {
            InitializeComponent();
            // dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ctr = ctr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ChooseEdition_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.DataSource = ctr.GetAllConferences();
                listBox1.DisplayMember = "Name";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (!ctr.CurrentUser.Rol.Equals("PCMember"))
            {
                this.btnAddEdition.Visible = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ///
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                try
                {
                    var results = ctr.GetAllEditions().Where(o => o.Conference.IdConference == (listBox1.SelectedItem as Conference).IdConference).ToList();
                    dataGridView1.DataSource = (List<Edition>)results;
                    dataGridView1.Columns["IdEdition"].Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Edition edition = (Edition)dataGridView1.SelectedRows[0].DataBoundItem;
                ctr.CurrentEdition = edition;
                ControlPanel panel = new ControlPanel(ctr, this);
                panel.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conference conference = listBox1.SelectedItem as Conference;
            AddEditionWindow editionWindow = new AddEditionWindow(conference, ctr);
            editionWindow.Show();
        }
    }
}
