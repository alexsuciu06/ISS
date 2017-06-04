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
    public partial class BiddingPage : Form
    {
        private int idCurrentPaper = -1;
        private MainClientController ctr;

        public BiddingPage(MainClientController ctr)
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ctr = ctr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                String data = dataGridView1.SelectedRows[0].Cells["Id"].ToString();
                this.idCurrentPaper = Int32.Parse(data);
            }
        }

        private void BiddingPage_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ctr.GetAllPapers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comboBox1.Items.Add("PLEASED_TO_REVIEW");
            comboBox1.Items.Add("COULD_EVALUATE");
            comboBox1.Items.Add("REFUZE_TO_EVALUATE");
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text.ToString();
            if(this.idCurrentPaper != -1)
            {
                ctr.AddBidding(idCurrentPaper, value);
            }

           // MessageBox.Show(comboBox1.Text.ToString());
        }
    }
}
