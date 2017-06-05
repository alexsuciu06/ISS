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
    public partial class AllReviews : Form
    {
        MainClientController ctr;

        public AllReviews(MainClientController ctr)
        {
            this.ctr = ctr;
            InitializeComponent();
            if (!ctr.CurrentUser.Role.Equals(Role.PCMember))
            {
                btnAddToSession.Visible = false;
            }
        }

        private void dataGridViewPapers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPapers.SelectedRows.Count > 0)
            {
                Paper p = dataGridViewPapers.SelectedRows[0].DataBoundItem as Paper;
                dataGridViewReviews.DataSource = ctr.GetReviewsForPaper(p);
            }
        }

        private void btnViewRecomandation_Click(object sender, EventArgs e)
        {
            if (dataGridViewPapers.SelectedRows.Count == 0)
            {
                return;
            }
            Review r = dataGridViewReviews.SelectedRows[0].DataBoundItem as Review;
            if (r.Recomandation == null || r.Recomandation.File == null || r.Recomandation.File == "")
            {
                MessageBox.Show("No recommandation was added.");
                return;
            }
            PDFDocViewer docvw = new PDFDocViewer(r.Recomandation.File);
            docvw.Show();
        }


        private void AllReviews_Load(object sender, EventArgs e)
        {
            if (ctr.CurrentUser.Role.Equals(Role.PCMember))
                dataGridViewPapers.DataSource = ctr.getAllPapersForEdition();
            else if (ctr.CurrentUser.Role.Equals(Role.Reviewer))
            {
                List<Review> my_reviews = ctr.GetAssignedReviews();
                List<Paper> my_papers = new List<Paper>();
                foreach (Review rev in my_reviews)
                {
                    my_papers.Add(rev.Paper);
                }
                dataGridViewPapers.DataSource = my_papers;
            }
                
        }


        private void btnAddToSession_Click(object sender, EventArgs e)
        {
            Paper p = null;
            if (dataGridViewPapers.SelectedRows.Count > 0)
            {
                p = dataGridViewPapers.SelectedRows[0].DataBoundItem as Paper;
            }
            CreateScheduleWindow win = new CreateScheduleWindow(p, ctr);
            win.Show();
        }
    }
}
