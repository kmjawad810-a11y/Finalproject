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
    public partial class Deals_and_Discounts : Form
    {
        private DataAccess Da { get; set; }
        
        public Deals_and_Discounts()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select Deal_Name, Electronics,Books,Foods from Manage_DandD2;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Page sp = new Student_Page();
            sp.Show();
        }

        private void Deals_and_Discounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Deals_and_Discounts_Load(object sender, EventArgs e)
        {

        }
    }
}
