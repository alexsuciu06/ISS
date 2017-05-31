using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class AddProposalWindow : Form
    {
        OpenFileDialog openFileDialogPaper = new OpenFileDialog();
        OpenFileDialog openFileDialogAbstract = new OpenFileDialog();

        String keywords = "";
        String topics = "";

        public AddProposalWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogPaper.ShowDialog();
            PaperTextBox.Text = Path.GetFileName(openFileDialogPaper.FileName);
        }

        private void AddProposalWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UploadAbstractButton_Click(object sender, EventArgs e)
        {
            openFileDialogAbstract.ShowDialog();
            AbstractTextBox.Text = Path.GetFileName(openFileDialogAbstract.FileName);
        }

        private void TopicsLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            getKeywordsTopics();
        }

        private void getKeywordsTopics()
        {
            keywords += KeywordsTextBox.Text;
            topics += TopicsTextBox.Text;
        }
        
    }
}
