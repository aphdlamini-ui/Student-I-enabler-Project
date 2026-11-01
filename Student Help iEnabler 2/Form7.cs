using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Help_iEnabler_2
{
    public partial class UpdateDetailsForm : Form
    {
        Form previousForm;
        private MenuForm parentMenuForm;

        public UpdateDetailsForm(Form prev)
        {
            InitializeComponent();
            previousForm = prev;
            parentMenuForm = prev as MenuForm;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Display current phone number from AppData
            PhoneNumbertextbox.Text = AppData.PhoneNumber;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void Previousbtn_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            PhoneNumbertextbox.Clear();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the phone number input from textbox
                string phoneInput = PhoneNumbertextbox.Text.Trim();

                // Validate that the textbox is not empty
                if (string.IsNullOrWhiteSpace(phoneInput))
                {
                    MessageBox.Show("Fields cannot be empty", "Empty Field",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PhoneNumbertextbox.Clear();
                    PhoneNumbertextbox.Focus();
                    return;
                }

                // Remove any spaces or special characters, keep only digits
                string phoneDigitsOnly = System.Text.RegularExpressions.Regex.Replace(phoneInput, @"[^\d]", "");

                // Validate that the phone number has exactly 10 digits
                if (phoneDigitsOnly.Length != 10)
                {
                    MessageBox.Show("Phone number must be exactly 10 digits. You entered " + phoneDigitsOnly.Length + " digit(s).",
                        "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PhoneNumbertextbox.Clear();
                    PhoneNumbertextbox.Focus();
                    return;
                }

                // Validate that all characters are digits
                if (!System.Text.RegularExpressions.Regex.IsMatch(phoneDigitsOnly, @"^\d{10}$"))
                {
                    MessageBox.Show("Phone number must contain only digits.", "Invalid Phone Number",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PhoneNumbertextbox.Clear();
                    PhoneNumbertextbox.Focus();
                    return;
                }

                // Confirm details
                DialogResult confirmDetails = MessageBox.Show(
                    "Is the information provided correct?",
                    "Confirm Details",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmDetails == DialogResult.No)
                {
                    MessageBox.Show("Please enter correct information");
                    PhoneNumbertextbox.Clear();
                    return;
                }

                // Confirm save
                DialogResult confirmSave = MessageBox.Show(
                    "Do you want to save the information?",
                    "Save Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmSave == DialogResult.Yes)
                {
                    // Format the phone number
                    string formattedPhoneNumber = phoneDigitsOnly;

                    // Update AppData with the new phone number
                    AppData.PhoneNumber = formattedPhoneNumber;

                    // Update the parent MenuForm with the new phone number
                    if (parentMenuForm != null)
                    {
                        parentMenuForm.LoadPhoneData(); // Refresh phone display in MenuForm
                    }

                    MessageBox.Show("Information saved successfully!");
                    PhoneNumbertextbox.Clear();
                    PhoneNumbertextbox.Focus();
                }
                else
                {
                    MessageBox.Show("Information not saved");
                    PhoneNumbertextbox.Clear();
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}