namespace CMS
{
    partial class ReviewPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddRecomandation = new System.Windows.Forms.Button();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRecomandation
            // 
            this.btnAddRecomandation.Location = new System.Drawing.Point(28, 53);
            this.btnAddRecomandation.Name = "btnAddRecomandation";
            this.btnAddRecomandation.Size = new System.Drawing.Size(86, 31);
            this.btnAddRecomandation.TabIndex = 0;
            this.btnAddRecomandation.Text = "Submit";
            this.btnAddRecomandation.UseVisualStyleBackColor = true;
           
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(159, 54);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(135, 30);
            this.btnSubmitReview.TabIndex = 1;
            this.btnSubmitReview.Text = "AdaugaRecomandare";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 129);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.btnAddRecomandation);
            this.Name = "ReviewPage";
            this.Text = "ReviewPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRecomandation;
        private System.Windows.Forms.Button btnSubmitReview;
    }
}