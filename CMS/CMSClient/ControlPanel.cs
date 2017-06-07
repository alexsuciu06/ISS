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
    public partial class ControlPanel : Form
    {
        private MainClientController ctr;
        private ChooseEdition sender;

        public ControlPanel(MainClientController ctrl, ChooseEdition sender)
        {
            InitializeComponent();
            ctr = ctrl;
            this.sender = sender;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            SetGratulationText();
            ChoosePanel();
        }

        private void ChoosePanel()
        {
            switch(ctr.CurrentUser.Rol)
            {
                case "Reviewer":
                    this.panelReviewer.Location = new Point(113,167);
                    this.panelReviewer.Show();
                    break;
                case "Author":
                    this.panelAuthor.Show();
                    this.panelAuthor.Location = new Point(125, 182);
                    break;
                case "PCMember":
                    this.panelPCMember.Show();
                    this.panelPCMember.Location = new Point(95, 143);
                    break;
                default:
                    this.panelListener.Show();
                    this.panelListener.Location = new Point(115, 261);
                    break;
            }
            
        }

        private void SetGratulationText()
        {
            string gratulation = 
                "Welcome, " + ctr.CurrentUser.First_name + "!\n" 
              + "These are the actions you can do as a " + ctr.CurrentUser.Rol ;

            this.gratulationLabel.Text = gratulation;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.sender.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            IEnumerable<LoginWindow> login = Application.OpenForms.OfType<LoginWindow>();
            if (login.Count() == 0)
            {
                LoginWindow loginWin = new LoginWindow(ctr);
                loginWin.Show();
            } else
            {
                login.ElementAt(0).Show();
            }
            
        }

        private void bidBtn_Click(object sender, EventArgs e)
        {
            BiddingPage page = new BiddingPage(ctr);
            page.Show();
        }

        private void myReviewsBtn_Click(object sender, EventArgs e)
        {
            MyReviewsPage myRevPage = new MyReviewsPage(ctr);
            myRevPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: View All reviews related to current user
        }

        private void OpenProgramme()
        {
            //TODO A schedule page
        }

        private void AddConferenceBtn(object sender, EventArgs e)
        {
            AddEditionWindow addEdwin = new AddEditionWindow(ctr.CurrentEdition.Conference, ctr);
            addEdwin.Show();
        }

        private void AssignReviewsBtn(object sender, EventArgs e)
        {
            AssignReviwer assignRevWin = new AssignReviwer(ctr);
            assignRevWin.Show();
        }

        private void AlllReviewsBtn(object sender, EventArgs e)
        {
            AllReviews allReviewsWin = new AllReviews(ctr);
            allReviewsWin.Show();
        }

        private void ViewScheduleBtn(object sender, EventArgs e)
        {
            CreateScheduleWindow csw = new CreateScheduleWindow(null, ctr);
            csw.Show();
        }

        private void AddProposalBtn(object sender, EventArgs e)
        {
            AddProposalWindow addPropWin = new AddProposalWindow(ctr);
            addPropWin.Show();
        }
    }
}
