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
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string Password = textBox2.Text.Trim();

            if (userName == "ashraful" && Password == "nobody")
            {
                MessageBox.Show("Welcome Student", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to Student page
                this.Hide();
                Student_Page sp = new Student_Page();
                sp.Show();

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                // Show error message
                MessageBox.Show("Invalid student credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear password field for security
                textBox2.Clear();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up su = new Sign_up();
           
            su.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get user inputs from textboxes
            string enteredName = textBox1.Text.Trim();
            string enteredPassword = textBox2.Text.Trim();
            
            // Check if credentials match the predefined values
            if (enteredName == "ashraful" && enteredPassword == "nobody")
            {
                // Show success message
                MessageBox.Show("Welcome sir", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Text = "";
                textBox2.Text = "";

                // Navigate to Admin page
                this.Hide();
                Admin ad = new Admin();
               
                ad.Show();
            }
            else
            {
                // Show error message
                MessageBox.Show("Login denied", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Clear password field for security
                textBox2.Clear();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
