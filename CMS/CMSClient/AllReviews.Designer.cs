namespace CMS
{
    partial class AllReviews
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
            this.dataGridViewPapers = new System.Windows.Forms.DataGridView();
            this.labelPApers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToSession = new System.Windows.Forms.Button();
            this.btnViewRecomandation = new System.Windows.Forms.Button();
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPapers
            // 
            this.dataGridViewPapers.AllowUserToAddRows = false;
            this.dataGridViewPapers.AllowUserToDeleteRows = false;
            this.dataGridViewPapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPapers.Location = new System.Drawing.Point(62, 87);
            this.dataGridViewPapers.Name = "dataGridViewPapers";
            this.dataGridViewPapers.ReadOnly = true;
            this.dataGridViewPapers.Size = new System.Drawing.Size(246, 246);
            this.dataGridViewPapers.TabIndex = 0;
            this.dataGridViewPapers.SelectionChanged += new System.EventHandler(this.dataGridViewPapers_SelectionChanged);
            // 
            // labelPApers
            // 
            this.labelPApers.AutoSize = true;
            this.labelPApers.Location = new System.Drawing.Point(59, 48);
            this.labelPApers.Name = "labelPApers";
            this.labelPApers.Size = new System.Drawing.Size(111, 13);
            this.labelPApers.TabIndex = 1;
            this.labelPApers.Text = "Papers for this edition:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reviews:";
            // 
            // btnAddToSession
            // 
            this.btnAddToSession.Location = new System.Drawing.Point(365, 365);
            this.btnAddToSession.Name = "btnAddToSession";
            this.btnAddToSession.Size = new System.Drawing.Size(152, 48);
            this.btnAddToSession.TabIndex = 4;
            this.btnAddToSession.Text = "Add Paper to a Session...";
            this.btnAddToSession.UseVisualStyleBackColor = true;
            this.btnAddToSession.Visible = false;
            this.btnAddToSession.Click += new System.EventHandler(this.btnAddToSession_Click);
            // 
            // btnViewRecomandation
            // 
            this.btnViewRecomandation.Location = new System.Drawing.Point(156, 365);
            this.btnViewRecomandation.Name = "btnViewRecomandation";
            this.btnViewRecomandation.Size = new System.Drawing.Size(152, 48);
            this.btnViewRecomandation.TabIndex = 6;
            this.btnViewRecomandation.Text = "View Recommandation file...";
            this.btnViewRecomandation.UseVisualStyleBackColor = true;
            this.btnViewRecomandation.Click += new System.EventHandler(this.btnViewRecomandation_Click);
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.AllowUserToAddRows = false;
            this.dataGridViewReviews.AllowUserToDeleteRows = false;
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Location = new System.Drawing.Point(365, 87);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.ReadOnly = true;
            this.dataGridViewReviews.Size = new System.Drawing.Size(246, 246);
            this.dataGridViewReviews.TabIndex = 7;
            // 
            // AllReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 462);
            this.Controls.Add(this.dataGridViewReviews);
            this.Controls.Add(this.btnViewRecomandation);
            this.Controls.Add(this.btnAddToSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPApers);
            this.Controls.Add(this.dataGridViewPapers);
            this.Name = "AllReviews";
            this.Text = "AllReviews";
            this.Load += new System.EventHandler(this.AllReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPapers;
        private System.Windows.Forms.Label labelPApers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToSession;
        private System.Windows.Forms.Button btnViewRecomandation;
        private System.Windows.Forms.DataGridView dataGridViewReviews;
    }
}