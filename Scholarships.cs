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
    public partial class Scholarships : Form
    {
        private DataAccess Da { get; set; }
        public Scholarships()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select Uni_Name, Sch_Name, Description, Eligibility, amount from Manage_Sch_Ship2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvScholarship.AutoGenerateColumns = false;
            this.dgvScholarship.DataSource = ds.Tables[0];
        }

        private void Scholarships_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Page sp = new Student_Page();
            sp.Show();
        }
    }
}
