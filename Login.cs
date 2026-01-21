using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }



        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtName.Text.Trim();
                string password = txtpass.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Please enter your username", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter your password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Focus();
                    return;
                }

                // Query
                string query = "SELECT Role, Status FROM SignUpDB WHERE Username = '" + userName + "' AND Password = '" + password + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    // User found - check status
                    int status = Convert.ToInt32(dt.Rows[0]["Status"]);
                    string role = dt.Rows[0]["Role"].ToString();

                    if (status == 0)
                    {
                        MessageBox.Show("Your account is inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtpass.Clear();
                        return;
                    }

                    // Status is 1 - Active account
                    MessageBox.Show("Welcome " + userName + "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form using FormClear
                    FormClear.ClearAllControls(this);

                    // Navigate based on role
                    this.Hide();
                    
                    if (role.ToUpper() == "ADMIN")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    else if (role.ToUpper() == "STUDENT")
                    {
                        Student_Page studentPage = new Student_Page();
                        studentPage.Show();
                    }
                    else if (role.ToUpper() == "VENDOR")
                    {
                        vendor vendorPage = new vendor();
                        vendorPage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid role assigned to this account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                    }
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
