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
        public Deals_and_Discounts()
        {
            InitializeComponent();
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
