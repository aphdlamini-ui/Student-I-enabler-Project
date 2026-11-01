using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace Student_Help_iEnabler_2
{
    public partial class LoginForm : Form
    {    
        public LoginForm()
        {
            InitializeComponent();
            // hide password with * when typing in the password of the user for security reasons
            PasswordInputBox.PasswordChar = '*';
            // optional: ensure checkbox starts unchecked so user can veiw password entered to check if it is accurate
            showPassCheckBox.Checked = false;
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(studentNoInputBox.Text) || string.IsNullOrWhiteSpace(PasswordInputBox.Text)) // check if either student number or password is empty or contains only whitespace
                {
                    MessageBox.Show("Please enter both student number and password.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message); // catch any unexpected exceptions and show an error message
                return;
            }

            string studentNumber = studentNoInputBox.Text;
            string password = PasswordInputBox.Text;

            string correctStudentNumber = "12345678";
            string correctPassword = "demo123";


            if (studentNumber == correctStudentNumber && password == correctPassword)
            {
                MessageBox.Show("Login successful!");

                MenuForm form2 = new MenuForm();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong student number or password!");
            }
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                // show password in plain text when checkbox is checked
                PasswordInputBox.PasswordChar = '\0';
            }
            else
            {
                // hide password again when checkbox is unchecked
                PasswordInputBox.PasswordChar = '*';
            }
        }

        private void forgotPaaword_Click(object sender, EventArgs e)
        {
            // Step 1: Confirm action
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset your password?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Step 2: Ask for student number
                string studentNumber = Interaction.InputBox(
                    "Enter your student number:",
                    "Password Reset",
                    ""
                );

                // Step 3: Validate input
                if (string.IsNullOrWhiteSpace(studentNumber))
                {
                    MessageBox.Show("Student number cannot be empty!");
                    return;
                }

                if (!long.TryParse(studentNumber, out _))
                {
                    MessageBox.Show("Student number must be numeric!");
                    return;
                }

                // Step 4: Generate email
                string email = studentNumber + "@student.example.ac.za";

                // Step 5: Show success message
                MessageBox.Show(
                    $"A password reset link has been sent to:\n{email}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
