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
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                dataGridView2.DataSource = ctr.GetAllConferences();
  
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                String data = dataGridView1.SelectedRows[0].Cells["IdEdition"].ToString();
                ctr.IdCurrentEdition = Int32.Parse(data);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    String data = dataGridView2.SelectedRows[0].Cells["IdConference"].Value.ToString();
                    var results = ctr.GetAllEditions().Where(o => o.Conference.IdConference == Int32.Parse(data)).ToList();
                    dataGridView1.DataSource = (List<Edition>)results;
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
    }
}
