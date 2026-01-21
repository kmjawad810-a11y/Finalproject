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

        private void Sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnregi_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string password = txtpass.Text.Trim();
                string role = cmbrole.SelectedItem?.ToString();

                // Validate inputs
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Please enter a username", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please select a role", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbrole.Focus();
                    return;
                }

                // Insert into database
                string query = "INSERT INTO SignUpDB (Username, Password, Role) VALUES ('" + userName + "', '" + password + "', '" + role + "')";
                int rowsAffected = this.Da.ExecuteDMLQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Clear form fields
                    FormClear.ClearAllControls(this);


                    // Navigate back to Login
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
