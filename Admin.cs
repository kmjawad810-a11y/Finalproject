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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();

            lg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Sch sch = new Edit_Sch();
            sch.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Deals_n_Discounts DnD = new Edit_Deals_n_Discounts();
            DnD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Uni_Fees UF = new Edit_Uni_Fees();
            UF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Part_Time_Job ptj = new Edit_Part_Time_Job();
            ptj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Loans ln = new Edit_Loans();
            ln.Show();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
