namespace CMS
{
    partial class AssignReviwer
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
            this.dataGridViewReviewers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPapers
            // 
            this.dataGridViewPapers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPapers.Location = new System.Drawing.Point(39, 52);
            this.dataGridViewPapers.Name = "dataGridViewPapers";
            this.dataGridViewPapers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridViewPapers.Size = new System.Drawing.Size(442, 242);
            this.dataGridViewPapers.TabIndex = 0;
            this.dataGridViewPapers.SelectionChanged += new System.EventHandler(this.dataGridViewPapers_SelectionChanged);
            // 
            // dataGridViewReviewers
            // 
            this.dataGridViewReviewers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReviewers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviewers.Location = new System.Drawing.Point(539, 52);
            this.dataGridViewReviewers.Name = "dataGridViewReviewers";
            this.dataGridViewReviewers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReviewers.Size = new System.Drawing.Size(370, 242);
            this.dataGridViewReviewers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Papers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reviewers";
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.Location = new System.Drawing.Point(539, 333);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(148, 35);
            this.buttonAddReview.TabIndex = 5;
            this.buttonAddReview.Text = "Assign Review";
            this.buttonAddReview.UseVisualStyleBackColor = true;
            this.buttonAddReview.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // AssignReviwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 409);
            this.Controls.Add(this.buttonAddReview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReviewers);
            this.Controls.Add(this.dataGridViewPapers);
            this.Name = "AssignReviwer";
            this.Text = "AssignReviwer";
            this.Load += new System.EventHandler(this.AssignReviwer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPapers;
        private System.Windows.Forms.DataGridView dataGridViewReviewers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddReview;
    }
}