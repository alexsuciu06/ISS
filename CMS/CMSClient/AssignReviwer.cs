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
    public partial class AssignReviwer : Form
    {
        private MainClientController ctr;

        public AssignReviwer(MainClientController c)
        {
            InitializeComponent();
            dataGridViewPapers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReviewers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ctr = c;
        }

        private void dataGridViewPapers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPapers.SelectedRows.Count > 0)
            {
                try
                {
                    Paper selected_papaer = (dataGridViewPapers.SelectedRows[0].DataBoundItem as Paper);
                    int paper_id = selected_papaer.Id;
                    dataGridViewReviewers.DataSource = ctr.getAllReviwers(paper_id);
                    dataGridViewReviewers.Columns["Id"].Visible = false;
                    dataGridViewReviewers.Columns["Paper"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            if (dataGridViewPapers.SelectedRows.Count == 1 && dataGridViewReviewers.SelectedRows.Count == 1)
            {
                Paper selected_papaer = (dataGridViewPapers.SelectedRows[0].DataBoundItem as Paper);
                Bid selected_bid = (dataGridViewReviewers.SelectedRows[0].DataBoundItem as Bid);

                User user = selected_bid.User;
                Reviewer reviewer = new Reviewer(user.Id, user.First_name, user.Affilation);

                ctr.addReview(selected_papaer, reviewer);
            }
            else
            {
                MessageBox.Show("You have selected too many rows or too few");
            }
        }

        private void AssignReviwer_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPapers.DataSource = ctr.GetAllPapers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
