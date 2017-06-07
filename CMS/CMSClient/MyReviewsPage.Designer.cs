namespace CMS
{
    partial class MyReviewsPage
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
            this.assignedReviewsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assignedReviewsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // assignedReviewsGrid
            // 
            this.assignedReviewsGrid.AllowUserToAddRows = false;
            this.assignedReviewsGrid.AllowUserToDeleteRows = false;
            this.assignedReviewsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assignedReviewsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedReviewsGrid.Location = new System.Drawing.Point(59, 73);
            this.assignedReviewsGrid.Name = "assignedReviewsGrid";
            this.assignedReviewsGrid.ReadOnly = true;
            this.assignedReviewsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assignedReviewsGrid.Size = new System.Drawing.Size(426, 247);
            this.assignedReviewsGrid.TabIndex = 0;
            this.assignedReviewsGrid.SelectionChanged += new System.EventHandler(this.assignedReviewsGrid_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assigned reviews";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Review now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyReviewsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignedReviewsGrid);
            this.Name = "MyReviewsPage";
            this.Text = "MyReviewsPage";
            this.Load += new System.EventHandler(this.MyReviewsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignedReviewsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assignedReviewsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}