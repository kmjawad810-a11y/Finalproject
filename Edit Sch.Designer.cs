namespace WindowsFormsApp1
{
    partial class Edit_Sch
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtEligibility = new System.Windows.Forms.TextBox();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.txtScholarship = new System.Windows.Forms.TextBox();
            this.txtUniName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvScholarship = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Admin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sch_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eligibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarship)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(116, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(25, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Eligibility:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scholarship:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Uni Name:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(126, 340);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // txtEligibility
            // 
            this.txtEligibility.Location = new System.Drawing.Point(126, 282);
            this.txtEligibility.Multiline = true;
            this.txtEligibility.Name = "txtEligibility";
            this.txtEligibility.Size = new System.Drawing.Size(100, 20);
            this.txtEligibility.TabIndex = 4;
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(126, 215);
            this.txtDescp.Multiline = true;
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(100, 20);
            this.txtDescp.TabIndex = 3;
            // 
            // txtScholarship
            // 
            this.txtScholarship.Location = new System.Drawing.Point(126, 155);
            this.txtScholarship.Multiline = true;
            this.txtScholarship.Name = "txtScholarship";
            this.txtScholarship.Size = new System.Drawing.Size(100, 20);
            this.txtScholarship.TabIndex = 2;
            // 
            // txtUniName
            // 
            this.txtUniName.Location = new System.Drawing.Point(126, 89);
            this.txtUniName.Multiline = true;
            this.txtUniName.Name = "txtUniName";
            this.txtUniName.Size = new System.Drawing.Size(100, 20);
            this.txtUniName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.dgvScholarship);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtEligibility);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDescp);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtScholarship);
            this.panel2.Controls.Add(this.txtUniName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(223, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 565);
            this.panel2.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(632, 475);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(713, 475);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(329, 475);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 32);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvScholarship
            // 
            this.dgvScholarship.AllowUserToAddRows = false;
            this.dgvScholarship.AllowUserToDeleteRows = false;
            this.dgvScholarship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScholarship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Admin_id,
            this.UniName,
            this.Sch_Name,
            this.Description,
            this.Eligibility,
            this.amount});
            this.dgvScholarship.Location = new System.Drawing.Point(329, 11);
            this.dgvScholarship.Name = "dgvScholarship";
            this.dgvScholarship.ReadOnly = true;
            this.dgvScholarship.Size = new System.Drawing.Size(645, 436);
            this.dgvScholarship.TabIndex = 0;
            this.dgvScholarship.DoubleClick += new System.EventHandler(this.dgvScholarship_DoubleClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 376);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(205, 39);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(120, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "panel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(22, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 56);
            this.label10.TabIndex = 19;
            this.label10.Text = "ADMIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(544, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 42);
            this.label11.TabIndex = 21;
            this.label11.Text = "SCHOLARSHIP";
            // 
            // Admin_id
            // 
            this.Admin_id.DataPropertyName = "Admin_id";
            this.Admin_id.HeaderText = "Admin_id";
            this.Admin_id.Name = "Admin_id";
            this.Admin_id.ReadOnly = true;
            // 
            // UniName
            // 
            this.UniName.DataPropertyName = "Uni_Name";
            this.UniName.HeaderText = "University Name";
            this.UniName.Name = "UniName";
            this.UniName.ReadOnly = true;
            // 
            // Sch_Name
            // 
            this.Sch_Name.DataPropertyName = "Sch_Name";
            this.Sch_Name.HeaderText = "Scholarship Name";
            this.Sch_Name.Name = "Sch_Name";
            this.Sch_Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Eligibility
            // 
            this.Eligibility.DataPropertyName = "Eligibility";
            this.Eligibility.HeaderText = "Eligibility";
            this.Eligibility.Name = "Eligibility";
            this.Eligibility.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // Edit_Sch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1245, 705);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDashboard);
            this.Name = "Edit_Sch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Sch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_Sch_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtEligibility;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.TextBox txtScholarship;
        private System.Windows.Forms.TextBox txtUniName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvScholarship;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sch_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eligibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}