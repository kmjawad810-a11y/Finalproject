using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class vendor : Form
    {
        private DataAccess Da { get; set; }
        
        public vendor()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from JobGiver2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvVendor.AutoGenerateColumns = false;
            this.dgvVendor.DataSource = ds.Tables[0];
        }

        private bool IsValidToSave()
        {
            if (
                string.IsNullOrEmpty(this.txtCompanyName.Text) ||
                string.IsNullOrEmpty(this.txtCorpo.Text) ||
                string.IsNullOrEmpty(this.txtFreelancer.Text) ||
                string.IsNullOrEmpty(this.txtStartup.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                var sql = "insert into JobGiver2 (CompanyName, Corporate, Freelancer, Startup) " +
                          "values ('" + this.txtCompanyName.Text + "', '" + this.txtCorpo.Text +
                          "', '" + this.txtFreelancer.Text + "', '" + this.txtStartup.Text + "');";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data has been added successfully");
                else
                    MessageBox.Show("Insert failed.");

                this.PopulateGridView();
                FormClear.ClearAllControls(this.panel3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvVendor.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var jobGiverId = this.dgvVendor.CurrentRow.Cells["JobGiver_id"].Value.ToString();
                var companyName = this.dgvVendor.CurrentRow.Cells["CompanyName"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + companyName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from JobGiver2 where JobGiver_id = " + jobGiverId + ";";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(companyName.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                FormClear.ClearAllControls(this.panel3);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void vendor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void vendor_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
