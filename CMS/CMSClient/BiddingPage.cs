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
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Paper _object = (Paper)dataGridView1.SelectedRows[0].DataBoundItem;
                PDFDocViewer doc_viewer = new PDFDocViewer(_object.File);
                doc_viewer.Show();
            }
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
            comboBox1.Items.Add("REFUSE_TO_EVALUATE");
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text.ToString();
            if ( dataGridView1.SelectedRows.Count == 0 )
            {
                return;
            }
            Paper selected = dataGridView1.SelectedRows[0].DataBoundItem as Paper;
            ctr.AddBidding(selected, value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Paper _object = (Paper)dataGridView1.SelectedRows[0].DataBoundItem;
                if(_object.Abs == null || _object.Abs.File == null || _object.Abs.File == "")
                {
                    MessageBox.Show("The abstract file was not loaded.\n Try to open the full paper");
                }
                PDFDocViewer doc_viewer = new PDFDocViewer(_object.Abs.File);
                doc_viewer.Show();
            }
        }
    }
}
