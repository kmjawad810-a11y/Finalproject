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
    public partial class Student_Page : Form
    {
        public Student_Page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Simply close this form - Login will automatically show again
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            University_fee uf  = new University_fee();
            uf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loans loans = new Loans();
            loans.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scholarships sc = new Scholarships();
            sc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Part_Time_jobs pt = new Part_Time_jobs();
            pt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deals_and_Discounts dd = new Deals_and_Discounts();
            dd.Show();
        }

        private void Student_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
