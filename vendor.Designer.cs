namespace WindowsFormsApp1
{
    partial class vendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendor));
            this.dgvVendor = new System.Windows.Forms.DataGridView();
            this.JobGiver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corporate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freelancer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartup = new System.Windows.Forms.TextBox();
            this.txtFreelancer = new System.Windows.Forms.TextBox();
            this.txtCorpo = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendor
            // 
            this.dgvVendor.AllowUserToAddRows = false;
            this.dgvVendor.AllowUserToDeleteRows = false;
            this.dgvVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobGiver_id,
            this.CompanyName,
            this.Corporate,
            this.Freelancer,
            this.startup});
            this.dgvVendor.Location = new System.Drawing.Point(297, 79);
            this.dgvVendor.Name = "dgvVendor";
            this.dgvVendor.ReadOnly = true;
            this.dgvVendor.Size = new System.Drawing.Size(644, 418);
            this.dgvVendor.TabIndex = 1;
            // 
            // JobGiver_id
            // 
            this.JobGiver_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobGiver_id.DataPropertyName = "JobGiver_id";
            this.JobGiver_id.HeaderText = "JobGiver ID";
            this.JobGiver_id.Name = "JobGiver_id";
            this.JobGiver_id.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // Corporate
            // 
            this.Corporate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Corporate.DataPropertyName = "Corporate";
            this.Corporate.HeaderText = "Corporate";
            this.Corporate.Name = "Corporate";
            this.Corporate.ReadOnly = true;
            // 
            // Freelancer
            // 
            this.Freelancer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Freelancer.DataPropertyName = "Freelancer";
            this.Freelancer.HeaderText = "Freelancer";
            this.Freelancer.Name = "Freelancer";
            this.Freelancer.ReadOnly = true;
            // 
            // startup
            // 
            this.startup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startup.DataPropertyName = "Startup";
            this.startup.HeaderText = "startup";
            this.startup.Name = "startup";
            this.startup.ReadOnly = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(841, 529);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout/back";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtStartup);
            this.panel3.Controls.Add(this.txtFreelancer);
            this.panel3.Controls.Add(this.txtCorpo);
            this.panel3.Controls.Add(this.txtCompanyName);
            this.panel3.Location = new System.Drawing.Point(5, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 418);
            this.panel3.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(19, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(253, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(19, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Startup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "FreeLancer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Corporate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Company Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // txtStartup
            // 
            this.txtStartup.Location = new System.Drawing.Point(127, 193);
            this.txtStartup.Multiline = true;
            this.txtStartup.Name = "txtStartup";
            this.txtStartup.Size = new System.Drawing.Size(100, 20);
            this.txtStartup.TabIndex = 4;
            // 
            // txtFreelancer
            // 
            this.txtFreelancer.Location = new System.Drawing.Point(127, 155);
            this.txtFreelancer.Multiline = true;
            this.txtFreelancer.Name = "txtFreelancer";
            this.txtFreelancer.Size = new System.Drawing.Size(100, 20);
            this.txtFreelancer.TabIndex = 3;
            // 
            // txtCorpo
            // 
            this.txtCorpo.Location = new System.Drawing.Point(127, 119);
            this.txtCorpo.Multiline = true;
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(100, 20);
            this.txtCorpo.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(127, 80);
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvVendor);
            this.panel2.Location = new System.Drawing.Point(193, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 583);
            this.panel2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(12, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 39);
            this.label8.TabIndex = 7;
            this.label8.Text = "VENDOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Location = new System.Drawing.Point(103, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1162, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Name = "vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vendor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vendor_FormClosing);
            this.Load += new System.EventHandler(this.vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendor;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartup;
        private System.Windows.Forms.TextBox txtFreelancer;
        private System.Windows.Forms.TextBox txtCorpo;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobGiver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corporate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freelancer;
        private System.Windows.Forms.DataGridViewTextBoxColumn startup;
    }
}