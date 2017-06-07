namespace CMS
{
    partial class AddEditionWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.EditionNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeadlineTextBox = new System.Windows.Forms.TextBox();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.EndsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edition Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditionNameTextBox
            // 
            this.EditionNameTextBox.Location = new System.Drawing.Point(124, 43);
            this.EditionNameTextBox.Name = "EditionNameTextBox";
            this.EditionNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.EditionNameTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(44, 208);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(216, 208);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Deadline:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start at:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ends at:";
            // 
            // DeadlineTextBox
            // 
            this.DeadlineTextBox.Location = new System.Drawing.Point(124, 78);
            this.DeadlineTextBox.Name = "DeadlineTextBox";
            this.DeadlineTextBox.Size = new System.Drawing.Size(167, 20);
            this.DeadlineTextBox.TabIndex = 9;
            // 
            // StartTextBox
            // 
            this.StartTextBox.Location = new System.Drawing.Point(124, 117);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(167, 20);
            this.StartTextBox.TabIndex = 10;
            // 
            // EndsTextBox
            // 
            this.EndsTextBox.Location = new System.Drawing.Point(124, 156);
            this.EndsTextBox.Name = "EndsTextBox";
            this.EndsTextBox.Size = new System.Drawing.Size(167, 20);
            this.EndsTextBox.TabIndex = 11;
            // 
            // AddEditionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 272);
            this.Controls.Add(this.EndsTextBox);
            this.Controls.Add(this.StartTextBox);
            this.Controls.Add(this.DeadlineTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.EditionNameTextBox);
            this.Controls.Add(this.label2);
            this.Name = "AddEditionWindow";
            this.Text = "AddEditionWindow";
            this.Load += new System.EventHandler(this.AddEditionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditionNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DeadlineTextBox;
        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.TextBox EndsTextBox;
    }
}