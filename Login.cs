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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = this.txtName.Text.Trim();
                var password = this.txtpass.Text.Trim();

                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Please enter your username");
                    this.txtName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter your password");
                    this.txtpass.Focus();
                    return;
                }

                var sql = "select Role, Status from SignUpDB where Username = '" + userName + "' and Password = '" + password + "';";
                var dt = this.Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    var status = Convert.ToInt32(dt.Rows[0]["Status"]);
                    var role = dt.Rows[0]["Role"].ToString();

                    if (status == 0)
                    {
                        MessageBox.Show("Your account is inactive. Please contact the administrator.");
                        this.txtpass.Clear();
                        return;
                    }

                    MessageBox.Show("Welcome " + userName + "!");

                    UserSession.LoggedInUsername = userName;
                    UserSession.LoggedInRole = role;

                    FormClear.ClearAllControls(this);

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
                        MessageBox.Show("Invalid role assigned to this account.");
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    this.txtpass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
