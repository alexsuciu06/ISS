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
    public partial class MyReviewsPage : Form
    {
        MainClientController ctr;

        public MyReviewsPage(MainClientController ctrl)
        {
            InitializeComponent();
            ctr = ctrl;
        }

        private void MyReviewsPage_Load(object sender, EventArgs e)
        {
            assignedReviewsGrid.DataSource = ctr.GetAssignedReviews();
            assignedReviewsGrid.Columns["Reviewer"].Visible = false;
            assignedReviewsGrid.Columns["IdReview"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Review selected = assignedReviewsGrid.SelectedRows[0].DataBoundItem as Review;
            ReviewPage review_page = new ReviewPage(selected, ctr);
            review_page.Show();
        }

        private void assignedReviewsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (assignedReviewsGrid.SelectedRows.Count == 0)
            {
                button1.Enabled = false;
            } else
            {
                Review selected = assignedReviewsGrid.SelectedRows[0].DataBoundItem as Review;
                if (selected.Grade == null)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                };
            }
        }
    }
}
