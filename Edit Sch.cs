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
    public partial class Edit_Sch : Form
    {
        private DataAccess Da { get; set; }
        
        public Edit_Sch()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Manage_Sch_Ship2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvScholarship.AutoGenerateColumns = false;
            this.dgvScholarship.DataSource = ds.Tables[0];
        }

        private void dgvScholarship_DoubleClick(object sender, EventArgs e)
        {
            this.txtUniName.Text = this.dgvScholarship.CurrentRow.Cells["UniName"].Value.ToString();
            this.txtScholarship.Text = this.dgvScholarship.CurrentRow.Cells["Sch_Name"].Value.ToString();
            this.txtDescp.Text = this.dgvScholarship.CurrentRow.Cells["Description"].Value.ToString();
            this.txtEligibility.Text = this.dgvScholarship.CurrentRow.Cells["Eligibility"].Value.ToString();
            this.txtAmount.Text = this.dgvScholarship.CurrentRow.Cells["amount"].Value.ToString();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUniName.Text) ||
                string.IsNullOrEmpty(this.txtScholarship.Text) ||
                string.IsNullOrEmpty(this.txtDescp.Text) ||
                string.IsNullOrEmpty(this.txtEligibility.Text) ||
                string.IsNullOrEmpty(this.txtAmount.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var adminId = UserSession.LoggedInUsername;
                if (string.IsNullOrEmpty(adminId))
                {
                    MessageBox.Show("No admin user logged in. Please login again.");
                    return;
                }

                var sql = "insert into Manage_Sch_Ship2 (Admin_id, Uni_Name, Sch_Name, Description, Eligibility, amount) " +
                          "values ('" + adminId + "', '" + this.txtUniName.Text + "', '" + this.txtScholarship.Text +
                          "', '" + this.txtDescp.Text + "', '" + this.txtEligibility.Text + "', '" + this.txtAmount.Text + "');";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Scholarship has been added successfully");
                else
                    MessageBox.Show("Insert failed.");

                this.PopulateGridView();
                FormClear.ClearAllControls(this.panel2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvScholarship.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to update.");
                    return;
                }

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var originalAdminId = this.dgvScholarship.CurrentRow.Cells["Admin_id"].Value.ToString();
                var originalUniName = this.dgvScholarship.CurrentRow.Cells["UniName"].Value.ToString();
                var originalSchName = this.dgvScholarship.CurrentRow.Cells["Sch_Name"].Value.ToString();

                var sql = "update Manage_Sch_Ship2 " +
                          "set Uni_Name = '" + this.txtUniName.Text +
                          "', Sch_Name = '" + this.txtScholarship.Text +
                          "', Description = '" + this.txtDescp.Text +
                          "', Eligibility = '" + this.txtEligibility.Text +
                          "', amount = '" + this.txtAmount.Text +
                          "' where Admin_id = '" + originalAdminId + "' and Uni_Name = '" + originalUniName + 
                          "' and Sch_Name = '" + originalSchName + "';";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data has been updated successfully");
                else
                    MessageBox.Show("Update failed. No matching record found.");

                this.PopulateGridView();
                FormClear.ClearAllControls(this.panel2);
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
                if (this.dgvScholarship.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var adminId = this.dgvScholarship.CurrentRow.Cells["Admin_id"].Value.ToString();
                var uniName = this.dgvScholarship.CurrentRow.Cells["UniName"].Value.ToString();
                var schName = this.dgvScholarship.CurrentRow.Cells["Sch_Name"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + schName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Manage_Sch_Ship2 where Admin_id = '" + adminId + "' and Uni_Name = '" + uniName + "' and Sch_Name = '" + schName + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(schName.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                FormClear.ClearAllControls(this.panel2);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void SearchScholarship()
        {
            var sql = "select * from Manage_Sch_Ship2 where Uni_Name like '%" + this.txtSearch.Text +
                "%' OR Sch_Name like '%" + this.txtSearch.Text + "%' OR Description like '%" + this.txtSearch.Text +
                "%' OR Eligibility like '%" + this.txtSearch.Text + "%';";

            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchScholarship();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }

        private void Edit_Sch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
