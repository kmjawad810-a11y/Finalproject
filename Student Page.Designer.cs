namespace WindowsFormsApp1
{
    partial class Student_Page
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPart = new System.Windows.Forms.Button();
            this.btnDeals = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnScholarship = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnUnifees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.btnPart);
            this.panel2.Controls.Add(this.btnDeals);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnScholarship);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.btnUnifees);
            this.panel2.Location = new System.Drawing.Point(104, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 468);
            this.panel2.TabIndex = 1;
            // 
            // btnPart
            // 
            this.btnPart.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPart.ForeColor = System.Drawing.Color.White;
            this.btnPart.Location = new System.Drawing.Point(0, 250);
            this.btnPart.Name = "btnPart";
            this.btnPart.Size = new System.Drawing.Size(308, 47);
            this.btnPart.TabIndex = 3;
            this.btnPart.Text = "Part-Time Jobs";
            this.btnPart.UseVisualStyleBackColor = false;
            this.btnPart.Click += new System.EventHandler(this.btnPart_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeals.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeals.ForeColor = System.Drawing.Color.White;
            this.btnDeals.Location = new System.Drawing.Point(0, 327);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(308, 49);
            this.btnDeals.TabIndex = 4;
            this.btnDeals.Text = "Deals n Discounts";
            this.btnDeals.UseVisualStyleBackColor = false;
            this.btnDeals.Click += new System.EventHandler(this.btnDeals_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Career and Income Opportunities";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(70, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lifestyle and Savings";
            // 
            // btnScholarship
            // 
            this.btnScholarship.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnScholarship.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnScholarship.ForeColor = System.Drawing.Color.White;
            this.btnScholarship.Location = new System.Drawing.Point(0, 165);
            this.btnScholarship.Name = "btnScholarship";
            this.btnScholarship.Size = new System.Drawing.Size(308, 50);
            this.btnScholarship.TabIndex = 0;
            this.btnScholarship.Text = "Scholarships";
            this.btnScholarship.UseVisualStyleBackColor = false;
            this.btnScholarship.Click += new System.EventHandler(this.btnScholarship_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Academic and Financial";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Maroon;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogout.Location = new System.Drawing.Point(107, 425);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(82, 31);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnUnifees
            // 
            this.btnUnifees.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUnifees.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnifees.ForeColor = System.Drawing.Color.White;
            this.btnUnifees.Location = new System.Drawing.Point(0, 82);
            this.btnUnifees.Name = "btnUnifees";
            this.btnUnifees.Size = new System.Drawing.Size(308, 48);
            this.btnUnifees.TabIndex = 2;
            this.btnUnifees.Text = "University Fees";
            this.btnUnifees.UseVisualStyleBackColor = false;
            this.btnUnifees.Click += new System.EventHandler(this.btnUnifees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dashboard";
            // 
            // Student_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(515, 712);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Student_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_Page_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnDeals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScholarship;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnifees;
    }
}