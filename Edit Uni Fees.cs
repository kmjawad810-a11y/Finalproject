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
    public partial class Edit_Uni_Fees : Form
    {
        private DataAccess Da { get; set; }
        
        public Edit_Uni_Fees()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Manage_Uni2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvUni.AutoGenerateColumns = false;
            this.dgvUni.DataSource = ds.Tables[0];
        }

        private void dgvUni_DoubleClick(object sender, EventArgs e)
        {
            this.txtUniName.Text = this.dgvUni.CurrentRow.Cells["Column1"].Value.ToString();
            this.txtprogram.Text = this.dgvUni.CurrentRow.Cells["Column2"].Value.ToString();
            this.txtcountry.Text = this.dgvUni.CurrentRow.Cells["Country"].Value.ToString();
            this.txtFee.Text = this.dgvUni.CurrentRow.Cells["Fee_Structure"].Value.ToString();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUniName.Text) ||
                string.IsNullOrEmpty(this.txtprogram.Text) ||
                string.IsNullOrEmpty(this.txtcountry.Text) ||
                string.IsNullOrEmpty(this.txtFee.Text))
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

                var sql = "insert into Manage_Uni2 (Uni_name, Program, Country, Fee_Structure) " +
                          "values ('" + this.txtUniName.Text + "', '" + this.txtprogram.Text +
                          "', '" + this.txtcountry.Text + "', '" + this.txtFee.Text + "');";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("University data has been added successfully");
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
                if (this.dgvUni.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to update.");
                    return;
                }

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var originalUniName = this.dgvUni.CurrentRow.Cells["Column1"].Value.ToString();
                var originalProgram = this.dgvUni.CurrentRow.Cells["Column2"].Value.ToString();

                var sql = "update Manage_Uni2 " +
                          "set Uni_name = '" + this.txtUniName.Text +
                          "', Program = '" + this.txtprogram.Text +
                          "', Country = '" + this.txtcountry.Text +
                          "', Fee_Structure = '" + this.txtFee.Text +
                          "' where Uni_name = '" + originalUniName + "' and Program = '" + originalProgram + "';";

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
                if (this.dgvUni.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var uniName = this.dgvUni.CurrentRow.Cells["Column1"].Value.ToString();
                var program = this.dgvUni.CurrentRow.Cells["Column2"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + uniName + " - " + program + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Manage_Uni2 where Uni_name = '" + uniName + "' and Program = '" + program + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(uniName.ToUpper() + " has been removed from the list");
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

        private void SearchUniversity()
        {
            var sql = "select * from Manage_Uni2 where Uni_name like '%" + this.txtsearch.Text +
                "%' OR Program like '%" + this.txtsearch.Text + "%' OR Country like '%" + this.txtsearch.Text +
                "%' OR Fee_Structure like '%" + this.txtsearch.Text + "%';";

            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchUniversity();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }

        private void Edit_Uni_Fees_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
