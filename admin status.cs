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
    public partial class admin_status : Form
    {
        private DataAccess Da { get; set; }
        
        public admin_status()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from SignUpDB;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvUserInfo.AutoGenerateColumns = false;
            this.dgvUserInfo.DataSource = ds.Tables[0];
        }

        private void dgvUserInfo_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvUserInfo.CurrentRow != null)
            {
                this.txtUserName.Text = this.dgvUserInfo.CurrentRow.Cells["Column1"].Value.ToString();
                this.txtPass.Text = this.dgvUserInfo.CurrentRow.Cells["Column2"].Value.ToString();
                this.cmbRole.Text = this.dgvUserInfo.CurrentRow.Cells["Role"].Value.ToString();
                this.txtStat.Text = this.dgvUserInfo.CurrentRow.Cells["Column3"].Value.ToString();
            }
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text) ||
                string.IsNullOrEmpty(this.txtPass.Text) ||
                this.cmbRole.SelectedItem == null ||
                string.IsNullOrEmpty(this.txtStat.Text))
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

                var sql = "insert into SignUpDB (Username, Password, Role, Status) " +
                          "values ('" + this.txtUserName.Text + "', '" + this.txtPass.Text +
                          "', '" + this.cmbRole.SelectedItem.ToString() + "', " + this.txtStat.Text + ");";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("User has been added successfully");
                else
                    MessageBox.Show("Insert failed.");

                this.PopulateGridView();
                FormClear.ClearAllControls(this.panel1);
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
                if (this.dgvUserInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to update.");
                    return;
                }

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var originalUsername = this.dgvUserInfo.CurrentRow.Cells["Column1"].Value.ToString();

                var sql = "update SignUpDB " +
                          "set Username = '" + this.txtUserName.Text +
                          "', Password = '" + this.txtPass.Text +
                          "', Role = '" + this.cmbRole.SelectedItem.ToString() +
                          "', Status = " + this.txtStat.Text +
                          " where Username = '" + originalUsername + "';";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data has been updated successfully");
                else
                    MessageBox.Show("Update failed. No matching record found.");

                this.PopulateGridView();
                FormClear.ClearAllControls(this.panel1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SearchUsers()
        {
            var sql = "select * from SignUpDB where Username like '%" + this.txtsearch.Text +
                "%' OR Role like '%" + this.txtsearch.Text + "%';";

            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchUsers();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }
    }
}
