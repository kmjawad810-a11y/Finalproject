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
    public partial class Part_Time_jobs : Form
    {
        private DataAccess Da { get; set; }
        public Part_Time_jobs()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select CompanyName, Corporate, Freelancer, startup from JobGiver2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }



        private void Part_Time_jobs_FormClosing(object sender, FormClosingEventArgs e)
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
