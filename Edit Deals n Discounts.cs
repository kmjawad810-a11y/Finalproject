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
    public partial class Edit_Deals_n_Discounts : Form
    {
        private DataAccess Da { get; set; }
        
        public Edit_Deals_n_Discounts()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Manage_DandD2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtDealName.Text = this.dataGridView1.CurrentRow.Cells["Deal_Name"].Value.ToString();
            this.txtElectro.Text = this.dataGridView1.CurrentRow.Cells["Electronics"].Value.ToString();
            this.txtbook.Text = this.dataGridView1.CurrentRow.Cells["Books"].Value.ToString();
            this.txtfoods.Text = this.dataGridView1.CurrentRow.Cells["Foods"].Value.ToString();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtDealName.Text) ||
                string.IsNullOrEmpty(this.txtElectro.Text) ||
                string.IsNullOrEmpty(this.txtbook.Text) ||
                string.IsNullOrEmpty(this.txtfoods.Text))
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

                var sql = "insert into Manage_DandD2 (Deal_Name, Electronics, Books, Foods) " +
                          "values ('" + this.txtDealName.Text + "', '" + this.txtElectro.Text +
                          "', '" + this.txtbook.Text + "', '" + this.txtfoods.Text + "');";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Deal has been added successfully");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to update.");
                    return;
                }

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var originalDealName = this.dataGridView1.CurrentRow.Cells["Deal_Name"].Value.ToString();

                var sql = "update Manage_DandD2 " +
                          "set Deal_Name = '" + this.txtDealName.Text +
                          "', Electronics = '" + this.txtElectro.Text +
                          "', Books = '" + this.txtbook.Text +
                          "', Foods = '" + this.txtfoods.Text +
                          "' where Deal_Name = '" + originalDealName + "';";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data has been updated successfully");
                else
                    MessageBox.Show("Update failed. No matching record found.");

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
                if (this.dataGridView1.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var dealName = this.dataGridView1.CurrentRow.Cells["Deal_Name"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + dealName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Manage_DandD2 where Deal_Name = '" + dealName + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(dealName.ToUpper() + " has been removed from the list");
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

        private void SearchDeals()
        {
            var sql = "select * from Manage_DandD2 where Deal_Name like '%" + this.txtSearch.Text +
                "%' OR Electronics like '%" + this.txtSearch.Text + "%' OR Books like '%" + this.txtSearch.Text +
                "%' OR Foods like '%" + this.txtSearch.Text + "%';";

            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchDeals();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }

        private void Edit_Deals_n_Discounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
