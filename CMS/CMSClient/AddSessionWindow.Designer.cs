namespace CMS
{
    partial class AddSessionWindow
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChairMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(172, 91);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(170, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add a presentation nsession by choosing the name, room and the session chair";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Session Chair Email:";
            // 
            // textBoxChairMail
            // 
            this.textBoxChairMail.Location = new System.Drawing.Point(172, 131);
            this.textBoxChairMail.Name = "textBoxChairMail";
            this.textBoxChairMail.Size = new System.Drawing.Size(170, 20);
            this.textBoxChairMail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room:";
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(82, 221);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(121, 33);
            this.btnAddSession.TabIndex = 7;
            this.btnAddSession.Text = "Add session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(172, 175);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(170, 21);
            this.comboBoxRooms.TabIndex = 8;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(221, 221);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(121, 33);
            this.buttonAddRoom.TabIndex = 9;
            this.buttonAddRoom.Text = "Add Room...";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // AddSessionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 285);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.comboBoxRooms);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxChairMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddSessionWindow";
            this.Text = "AddSessionWindow";
            this.Load += new System.EventHandler(this.AddSessionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChairMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.Button buttonAddRoom;
    }
}