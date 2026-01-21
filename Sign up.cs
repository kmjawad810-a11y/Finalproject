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
    public partial class Sign_up : Form
    {
        private DataAccess Da { get; set; }
        
        public Sign_up()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text) ||
                string.IsNullOrEmpty(this.txtpass.Text) ||
                this.cmbrole.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnregi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var sql = "insert into SignUpDB (Username, Password, Role) " +
                          "values ('" + this.txtUserName.Text + "', '" + this.txtpass.Text + "', '" + this.cmbrole.SelectedItem.ToString() + "');";

                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Registration successful!");
                else
                    MessageBox.Show("Registration failed.");

                FormClear.ClearAllControls(this);

                this.Hide();
                Login login = new Login();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
