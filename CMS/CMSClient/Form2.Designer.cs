﻿namespace CMS
{
    partial class Form2
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
            this.EditionDataGridView = new System.Windows.Forms.DataGridView();
            this.SessionDataGridView = new System.Windows.Forms.DataGridView();
            this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SingUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.labelEdition = new System.Windows.Forms.Label();
            this.labelSession = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditionDataGridView
            // 
            this.EditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditionDataGridView.Location = new System.Drawing.Point(80, 71);
            this.EditionDataGridView.Name = "EditionDataGridView";
            this.EditionDataGridView.RowTemplate.Height = 40;
            this.EditionDataGridView.Size = new System.Drawing.Size(656, 302);
            this.EditionDataGridView.TabIndex = 0;
            // 
            // SessionDataGridView
            // 
            this.SessionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionDataGridView.Location = new System.Drawing.Point(80, 457);
            this.SessionDataGridView.Name = "SessionDataGridView";
            this.SessionDataGridView.RowTemplate.Height = 40;
            this.SessionDataGridView.Size = new System.Drawing.Size(656, 317);
            this.SessionDataGridView.TabIndex = 1;
            // 
            // LoginLinkLabel
            // 
            this.LoginLinkLabel.AutoSize = true;
            this.LoginLinkLabel.Location = new System.Drawing.Point(1404, 9);
            this.LoginLinkLabel.Name = "LoginLinkLabel";
            this.LoginLinkLabel.Size = new System.Drawing.Size(86, 32);
            this.LoginLinkLabel.TabIndex = 2;
            this.LoginLinkLabel.TabStop = true;
            this.LoginLinkLabel.Text = "Login";
            // 
            // SingUpLinkLabel
            // 
            this.SingUpLinkLabel.AutoSize = true;
            this.SingUpLinkLabel.Location = new System.Drawing.Point(1404, 55);
            this.SingUpLinkLabel.Name = "SingUpLinkLabel";
            this.SingUpLinkLabel.Size = new System.Drawing.Size(112, 32);
            this.SingUpLinkLabel.TabIndex = 3;
            this.SingUpLinkLabel.TabStop = true;
            this.SingUpLinkLabel.Text = "Sing up";
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Location = new System.Drawing.Point(905, 183);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(543, 542);
            this.DetailsPanel.TabIndex = 4;
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Location = new System.Drawing.Point(74, 18);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(104, 32);
            this.labelEdition.TabIndex = 5;
            this.labelEdition.Text = "Edition";
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(74, 401);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(117, 32);
            this.labelSession.TabIndex = 6;
            this.labelSession.Text = "Session";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(301, 801);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(139, 42);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 883);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.SingUpLinkLabel);
            this.Controls.Add(this.LoginLinkLabel);
            this.Controls.Add(this.SessionDataGridView);
            this.Controls.Add(this.EditionDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.EditionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditionDataGridView;
        private System.Windows.Forms.DataGridView SessionDataGridView;
        private System.Windows.Forms.LinkLabel LoginLinkLabel;
        private System.Windows.Forms.LinkLabel SingUpLinkLabel;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Button RegisterButton;
    }
}