namespace CMS
{
    partial class AddProposalWindow
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
            this.UploadPaperButton = new System.Windows.Forms.Button();
            this.PaperTextBox = new System.Windows.Forms.TextBox();
            this.AbstractTextBox = new System.Windows.Forms.TextBox();
            this.KeywordsTextBox = new System.Windows.Forms.TextBox();
            this.KeywordsLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.UploadAbstractButton = new System.Windows.Forms.Button();
            this.TopicsLabel = new System.Windows.Forms.Label();
            this.TopicsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UploadPaperButton
            // 
            this.UploadPaperButton.Location = new System.Drawing.Point(58, 52);
            this.UploadPaperButton.Name = "UploadPaperButton";
            this.UploadPaperButton.Size = new System.Drawing.Size(100, 23);
            this.UploadPaperButton.TabIndex = 0;
            this.UploadPaperButton.Text = "Upload Paper";
            this.UploadPaperButton.UseVisualStyleBackColor = true;
            this.UploadPaperButton.Click += new System.EventHandler(this.UploadPaperButton_Click);
            // 
            // PaperTextBox
            // 
            this.PaperTextBox.Location = new System.Drawing.Point(164, 54);
            this.PaperTextBox.Name = "PaperTextBox";
            this.PaperTextBox.Size = new System.Drawing.Size(167, 20);
            this.PaperTextBox.TabIndex = 1;
            //this.PaperTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AbstractTextBox
            // 
            this.AbstractTextBox.Location = new System.Drawing.Point(164, 83);
            this.AbstractTextBox.Name = "AbstractTextBox";
            this.AbstractTextBox.Size = new System.Drawing.Size(167, 20);
            this.AbstractTextBox.TabIndex = 2;
            // 
            // KeywordsTextBox
            // 
            this.KeywordsTextBox.Location = new System.Drawing.Point(58, 142);
            this.KeywordsTextBox.Name = "KeywordsTextBox";
            this.KeywordsTextBox.Size = new System.Drawing.Size(273, 20);
            this.KeywordsTextBox.TabIndex = 3;
            // 
            // KeywordsLabel
            // 
            this.KeywordsLabel.AutoSize = true;
            this.KeywordsLabel.Location = new System.Drawing.Point(55, 126);
            this.KeywordsLabel.Name = "KeywordsLabel";
            this.KeywordsLabel.Size = new System.Drawing.Size(53, 13);
            this.KeywordsLabel.TabIndex = 6;
            this.KeywordsLabel.Text = "Keywords";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(161, 232);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // UploadAbstractButton
            // 
            this.UploadAbstractButton.Location = new System.Drawing.Point(58, 81);
            this.UploadAbstractButton.Name = "UploadAbstractButton";
            this.UploadAbstractButton.Size = new System.Drawing.Size(100, 23);
            this.UploadAbstractButton.TabIndex = 8;
            this.UploadAbstractButton.Text = "Upload Abstract";
            this.UploadAbstractButton.UseVisualStyleBackColor = true;
            this.UploadAbstractButton.Click += new System.EventHandler(this.UploadAbstractButton_Click);
            // 
            // TopicsLabel
            // 
            this.TopicsLabel.AutoSize = true;
            this.TopicsLabel.Location = new System.Drawing.Point(55, 176);
            this.TopicsLabel.Name = "TopicsLabel";
            this.TopicsLabel.Size = new System.Drawing.Size(39, 13);
            this.TopicsLabel.TabIndex = 9;
            this.TopicsLabel.Text = "Topics";
            //this.TopicsLabel.Click += new System.EventHandler(this.TopicsLabel_Click);
            // 
            // TopicsTextBox
            // 
            this.TopicsTextBox.Location = new System.Drawing.Point(58, 192);
            this.TopicsTextBox.Name = "TopicsTextBox";
            this.TopicsTextBox.Size = new System.Drawing.Size(273, 20);
            this.TopicsTextBox.TabIndex = 10;
            //this.TopicsTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // AddProposalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 288);
            this.Controls.Add(this.TopicsTextBox);
            this.Controls.Add(this.TopicsLabel);
            this.Controls.Add(this.UploadAbstractButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.KeywordsLabel);
            this.Controls.Add(this.KeywordsTextBox);
            this.Controls.Add(this.AbstractTextBox);
            this.Controls.Add(this.PaperTextBox);
            this.Controls.Add(this.UploadPaperButton);
            this.Name = "AddProposalWindow";
            this.Text = "AddProposalWindow";
            //this.Load += new System.EventHandler(this.AddProposalWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadPaperButton;
        private System.Windows.Forms.TextBox PaperTextBox;
        private System.Windows.Forms.TextBox AbstractTextBox;
        private System.Windows.Forms.TextBox KeywordsTextBox;
        private System.Windows.Forms.Label KeywordsLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button UploadAbstractButton;
        private System.Windows.Forms.Label TopicsLabel;
        private System.Windows.Forms.TextBox TopicsTextBox;
    }
}