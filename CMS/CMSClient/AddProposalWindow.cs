using CMS.Controllers;
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

        public MainClientController ctrl;

        public AddProposalWindow(MainClientController ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
        }

        private void UploadAbstractButton_Click(object sender, EventArgs e)
        {

            openFileDialogAbstract.ShowDialog();
            AbstractTextBox.Text = openFileDialogAbstract.FileName;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.SubmitProposal(
                        textBoxPaperName.Text,
                        textBoxCoAuthors.Text,
                        KeywordsTextBox.Text.Split(','),
                        TopicsTextBox.Text.Split(','),
                        AbstractTextBox.Text,
                        PaperTextBox.Text
                    );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error submitting proposal", MessageBoxButtons.OK);
            }
        }

        private void UploadPaperButton_Click(object sender, EventArgs e)
        {
            openFileDialogPaper.ShowDialog();
            PaperTextBox.Text = openFileDialogPaper.FileName;
        }
    }
}
