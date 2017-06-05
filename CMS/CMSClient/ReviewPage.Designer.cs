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
            this.btnReadFull = new System.Windows.Forms.Button();
            this.addRecomandationBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.btnReadAbstract = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxVote = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadFull
            // 
            this.btnReadFull.Location = new System.Drawing.Point(43, 110);
            this.btnReadFull.Name = "btnReadFull";
            this.btnReadFull.Size = new System.Drawing.Size(129, 31);
            this.btnReadFull.TabIndex = 0;
            this.btnReadFull.Text = "Read Full Paper...";
            this.btnReadFull.UseVisualStyleBackColor = true;
            this.btnReadFull.Click += new System.EventHandler(this.btnReadFull_Click);
            // 
            // addRecomandationBtn
            // 
            this.addRecomandationBtn.Location = new System.Drawing.Point(207, 238);
            this.addRecomandationBtn.Name = "addRecomandationBtn";
            this.addRecomandationBtn.Size = new System.Drawing.Size(135, 30);
            this.addRecomandationBtn.TabIndex = 1;
            this.addRecomandationBtn.Text = "Add Recommandation...";
            this.addRecomandationBtn.UseVisualStyleBackColor = true;
            this.addRecomandationBtn.Click += new System.EventHandler(this.addRecomandationBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(134, 316);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(115, 55);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit Review";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // btnReadAbstract
            // 
            this.btnReadAbstract.Location = new System.Drawing.Point(207, 111);
            this.btnReadAbstract.Name = "btnReadAbstract";
            this.btnReadAbstract.Size = new System.Drawing.Size(121, 31);
            this.btnReadAbstract.TabIndex = 3;
            this.btnReadAbstract.Text = "Read Abstract...";
            this.btnReadAbstract.UseVisualStyleBackColor = true;
            this.btnReadAbstract.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBoxVote
            // 
            this.comboBoxVote.FormattingEnabled = true;
            this.comboBoxVote.Items.AddRange(new object[] {
            "STRONG_ACCEPT",
            "ACCEPT",
            "WEAK_ACCEPT",
            "BORDERLINE_PAPER",
            "WEAK_REJECT",
            "REJECT",
            "STRONG_REJECT"});
            this.comboBoxVote.Location = new System.Drawing.Point(103, 186);
            this.comboBoxVote.Name = "comboBoxVote";
            this.comboBoxVote.Size = new System.Drawing.Size(239, 21);
            this.comboBoxVote.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(40, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(134, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "This is the review page for ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vote:";
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxVote);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReadAbstract);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.addRecomandationBtn);
            this.Controls.Add(this.btnReadFull);
            this.Name = "ReviewPage";
            this.Text = "ReviewPage";
            this.Load += new System.EventHandler(this.ReviewPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFull;
        private System.Windows.Forms.Button addRecomandationBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button btnReadAbstract;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxVote;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
    }
}