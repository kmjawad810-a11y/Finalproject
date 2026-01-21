namespace WindowsFormsApp1
{
    partial class Admin
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
            this.EditSch = new System.Windows.Forms.Button();
            this.editUniFee = new System.Windows.Forms.Button();
            this.editdeals = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditSch
            // 
            this.EditSch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EditSch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSch.ForeColor = System.Drawing.Color.White;
            this.EditSch.Location = new System.Drawing.Point(57, 37);
            this.EditSch.Name = "EditSch";
            this.EditSch.Size = new System.Drawing.Size(286, 46);
            this.EditSch.TabIndex = 4;
            this.EditSch.Text = "Edit Scholarships";
            this.EditSch.UseVisualStyleBackColor = false;
            this.EditSch.Click += new System.EventHandler(this.button1_Click);
            // 
            // editUniFee
            // 
            this.editUniFee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editUniFee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUniFee.ForeColor = System.Drawing.Color.White;
            this.editUniFee.Location = new System.Drawing.Point(57, 193);
            this.editUniFee.Name = "editUniFee";
            this.editUniFee.Size = new System.Drawing.Size(286, 46);
            this.editUniFee.TabIndex = 6;
            this.editUniFee.Text = "Edit University Fees";
            this.editUniFee.UseVisualStyleBackColor = false;
            this.editUniFee.Click += new System.EventHandler(this.button3_Click);
            // 
            // editdeals
            // 
            this.editdeals.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editdeals.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.editdeals.ForeColor = System.Drawing.Color.White;
            this.editdeals.Location = new System.Drawing.Point(57, 116);
            this.editdeals.Name = "editdeals";
            this.editdeals.Size = new System.Drawing.Size(286, 46);
            this.editdeals.TabIndex = 7;
            this.editdeals.Text = "Edit Deals n Discounts";
            this.editdeals.UseVisualStyleBackColor = false;
            this.editdeals.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Brown;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(143, 311);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(101, 35);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.EditSch);
            this.panel1.Controls.Add(this.editUniFee);
            this.panel1.Controls.Add(this.editdeals);
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 360);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(132, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 56);
            this.label8.TabIndex = 11;
            this.label8.Text = "ADMIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(221, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dashboard";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(424, 536);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditSch;
        private System.Windows.Forms.Button editUniFee;
        private System.Windows.Forms.Button editdeals;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}