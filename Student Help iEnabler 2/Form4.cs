using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Help_iEnabler_2
{
    public partial class FirstYearRegistrationForm : Form
    {
        private const int CREDITS_PER_MODULE = 16;
        private const int MAX_CREDITS = 128;
        private const int REQUIRED_CREDITS = 128;
        private const decimal COST_PER_MODULE = 3800.00m;

        public FirstYearRegistrationForm()
        {
            InitializeComponent();
            this.Load+=Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Initialize credit textboxes on form load
            creditsAvaitxtBox.Text = MAX_CREDITS.ToString();
            creditsSelecttxtBox.Text = "0";

            // Attach CheckedChanged event to all checkboxes in ModuleGroupBox
            foreach (Control control in ModuleGroupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCredits();
        }

        private void UpdateCredits()
        {
            try
            {
                int creditsSelected = 0;

                // Count checked boxes 
                foreach (Control control in ModuleGroupBox.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        creditsSelected += CREDITS_PER_MODULE;
                    }
                }

                // Calculate available credits
                int creditsAvailable = MAX_CREDITS - creditsSelected;

                // Update textboxes in CreditsGroupBox
                creditsAvaitxtBox.Text = creditsAvailable.ToString();
                creditsSelecttxtBox.Text = creditsSelected.ToString();

                // Show warning if student exceeds maximum credits
                if (creditsSelected > MAX_CREDITS)
                {
                    MessageBox.Show("You have exceeded the maximum credit limit of 128. Please uncheck some modules.",
                        "Credit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating credits: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Moduleguidebtn_Click(object sender, EventArgs e)
        {
            ModuleGuideForm f8 = new ModuleGuideForm(this);
            f8.Show();
            this.Hide();
        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MenuForm"] is MenuForm f2)
            {
                f2.Show();
                this.Close();
            }
            else
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Close();
            }


        }

        private void Logoutlbl_Click_1(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void Restartbtn2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Uncheck all checkboxes in ModuleGroupBox
                foreach (Control control in ModuleGroupBox.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        checkBox.Checked = false;
                    }
                }

                // Reset credit textboxes in CreditsGroupBox to initial values
                creditsAvaitxtBox.Text = MAX_CREDITS.ToString();
                creditsSelecttxtBox.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restarting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Completebtn2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int creditsSelected = int.Parse(creditsSelecttxtBox.Text);

                // Validate that student has selected exactly 128 credits (8 modules)
                if (creditsSelected < REQUIRED_CREDITS)
                {
                    MessageBox.Show($"Please select at least {REQUIRED_CREDITS} credits. You currently have {creditsSelected} credits.",
                        "Insufficient Credits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (creditsSelected > REQUIRED_CREDITS)
                {
                    MessageBox.Show($"You must select exactly {REQUIRED_CREDITS} credits. You currently have {creditsSelected} credits.",
                        "Too Many Credits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculate number of modules selected
                int modulesSelected = creditsSelected / CREDITS_PER_MODULE;

                // Calculate total cost
                decimal totalCost = modulesSelected * COST_PER_MODULE;

                string registeredModules = "You have successfully registered for the following:\n\n";
                string modulesList = ""; // Store module names for AppData
                bool anyChecked = false;

                // Dictionary to map checkbox names to their display text (8 modules for first-year)
                Dictionary<string, string> moduleMap = new Dictionary<string, string>()
                {
                    { "FINCcheckBox", "Finance - FINC101" },
                    { "STATSBcheckBox", "Statistics - STATSB101" },
                    { "TECHNcheckBox", "Technology - TECHN101" },
                    { "LAWcheckBox", "Business Law - LAW101" },
                    { "MNGTcheckBox", "Introduction to Management - MNGT101" },
                    { "BScheckBox", "Business Studies - BS101" },
                    { "ACCcheckBox", "Accounting Fundamentals - ACC101" },
                    { "InvcheckBox", "Investment - INV101" }
                };

                // Loop through all controls in ModuleGroupBox
                foreach (Control control in ModuleGroupBox.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        // Check if this checkbox is in our module map
                        if (moduleMap.ContainsKey(control.Name))
                        {
                            registeredModules += "• " + moduleMap[control.Name] + "\n";
                            modulesList += moduleMap[control.Name] + "\n";
                            anyChecked = true;
                        }
                    }
                }

                // Display message with cost breakdown
                if (anyChecked)
                {
                    registeredModules += $"\n\n--- REGISTRATION SUMMARY ---";
                    registeredModules += $"\nTotal Credits: {creditsSelected} out of {MAX_CREDITS}";
                    registeredModules += $"\nTotal Modules: {modulesSelected}";
                    registeredModules += $"\nCost per Module: R{COST_PER_MODULE:F2}";
                    registeredModules += $"\n\nTOTAL AMOUNT DUE: R{totalCost:F2}";

                    MessageBox.Show(registeredModules, "Registration Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Store the total cost, modules count, and modules list in AppData
                    AppData.TotalAmountDue = $"R{totalCost:F2}";
                    AppData.RegisteredModulesCount = modulesSelected.ToString();
                    AppData.RegisteredModules = modulesList.Trim();

                    // Try to find existing MenuForm instance first
                    if (Application.OpenForms["MenuForm"] is MenuForm menuForm)
                    {
                        // If it exists, refresh its data and show it
                        menuForm.LoadData();
                        menuForm.Show();
                        menuForm.BringToFront();
                    }
                    else
                    {
                        // If it doesn't exist, create a new one
                        menuForm = new MenuForm();
                        menuForm.Show();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select all 8 modules.", "No Modules Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Supportlbl_Click_1(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter your message for support:", "Contact Support", "Type your message here...");
            if (!string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Your message has been sent to support.", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTime.Now;
        }
    }
    
    
}