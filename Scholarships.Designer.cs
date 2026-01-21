namespace WindowsFormsApp1
{
    partial class Scholarships
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
            this.dgvScholarship = new System.Windows.Forms.DataGridView();
            this.UniversityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScholarshipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eligibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarship)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScholarship
            // 
            this.dgvScholarship.AllowUserToAddRows = false;
            this.dgvScholarship.AllowUserToDeleteRows = false;
            this.dgvScholarship.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvScholarship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScholarship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UniversityName,
            this.ScholarshipName,
            this.Description,
            this.Eligibility,
            this.Amount});
            this.dgvScholarship.Location = new System.Drawing.Point(12, 86);
            this.dgvScholarship.Name = "dgvScholarship";
            this.dgvScholarship.ReadOnly = true;
            this.dgvScholarship.Size = new System.Drawing.Size(828, 338);
            this.dgvScholarship.TabIndex = 4;
            // 
            // UniversityName
            // 
            this.UniversityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UniversityName.DataPropertyName = "Uni_Name";
            this.UniversityName.HeaderText = "University Name";
            this.UniversityName.Name = "UniversityName";
            this.UniversityName.ReadOnly = true;
            // 
            // ScholarshipName
            // 
            this.ScholarshipName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScholarshipName.DataPropertyName = "Sch_Name";
            this.ScholarshipName.HeaderText = "Scholarship Name";
            this.ScholarshipName.Name = "ScholarshipName";
            this.ScholarshipName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Eligibility
            // 
            this.Eligibility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eligibility.DataPropertyName = "Eligibility";
            this.Eligibility.HeaderText = "Eligibility";
            this.Eligibility.Name = "Eligibility";
            this.Eligibility.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(764, 446);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "SCHOLARSHIPS";
            // 
            // Scholarships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(851, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvScholarship);
            this.Name = "Scholarships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCHOLARSHIPS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scholarships_FormClosing);
            this.Load += new System.EventHandler(this.Scholarships_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvScholarship;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniversityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScholarshipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eligibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}