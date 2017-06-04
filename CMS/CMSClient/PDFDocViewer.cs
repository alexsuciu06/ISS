using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ceTe.DynamicPDF.Viewer;

namespace CMS
{
    public partial class PDFDocViewer : Form
    {
        PdfDocument doc;

        public PDFDocViewer(string filePath)
        {
            InitializeComponent();
            doc = new PdfDocument(filePath);
            pdfViewer1.Open(doc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void pdfFontViewerControl1_Click(object sender, EventArgs e)
        {

        }

        private void pdfViewer1_Click(object sender, EventArgs e)
        {

        }
    }
}
