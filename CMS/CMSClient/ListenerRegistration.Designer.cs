namespace CMS
{
    partial class ListenerRegistration
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
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.labelSession = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Location = new System.Drawing.Point(328, 52);
            this.DetailsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(204, 256);
            this.DetailsPanel.TabIndex = 4;
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(42, 52);
            this.labelSession.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(44, 13);
            this.labelSession.TabIndex = 6;
            this.labelSession.Text = "Session";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(74, 280);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(1);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(125, 28);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 173);
            this.listBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "New Session...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListenerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.DetailsPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ListenerRegistration";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}