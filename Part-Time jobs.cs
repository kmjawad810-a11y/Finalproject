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
        public Part_Time_jobs()
        {
            InitializeComponent();
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
