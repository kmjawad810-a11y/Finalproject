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







        private void Student_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            // Simply close this form - Login will automatically show again
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btnUnifees_Click(object sender, EventArgs e)
        {

        }
    }
}
