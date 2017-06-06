using CMS.Controllers;
using CMS.Validations;
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
    public partial class ReviewPage : Form
    {
        Review review;
        Recomandation recomandation = null;
        MainClientController ctr;

        public ReviewPage() { }

        public ReviewPage(Review rev, MainClientController ctr)
        {
            InitializeComponent();
            review = rev;
            this.ctr = ctr;
        }

        private void ReviewPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.review.Paper.Abs == null || this.review.Paper.Abs.File == null || this.review.Paper.Abs.File.Equals(""))
            {
                MessageBox.Show("The abstract was not loaded!");
                return;
            }
            PDFDocViewer docviewer = new PDFDocViewer(review.Paper.Abs.File);
            docviewer.Show();
        }

        private void btnReadFull_Click(object sender, EventArgs e)
        {
            if(this.review.Paper.File == null || this.review.Paper.File.Equals(""))
            {
                MessageBox.Show("The full paper was not loaded!");
                return;
            }
            PDFDocViewer docviewer = new PDFDocViewer(review.Paper.File);
            docviewer.Show();
        }

        private void addRecomandationBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            this.textBox1.Text = ofd.FileName;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSubmit(); // sets the recommandation file if valid
                review.Grade = comboBoxVote.Text;
                review.Recomandation = this.recomandation;
                ctr.SubmitReview(review);
                (sender as Button).Text = "Update this review";
            } catch (CMS.Validations.DataException de)
            {
                MessageBox.Show(de.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ValidateSubmit()
        {
            if (comboBoxVote.Text == "")
            {
                throw new CMS.Validations.DataException("You must select a vote");
            }
            if (!textBox1.Text.Equals(""))
            {
                ValidationData.ValidatePdfFile(textBox1.Text);
                recomandation = new Recomandation(textBox1.Text);
            }
        }
    }
}
