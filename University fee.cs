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
    public partial class University_fee : Form
    {
        private DataAccess Da { get; set; }
        public University_fee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select Uni_name, Program, Country, Fee_Structure from Manage_Uni2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvUniFee.AutoGenerateColumns = true;
            this.dgvUniFee.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Page sp = new Student_Page();
            sp.Show();
        }

        private void University_fee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
