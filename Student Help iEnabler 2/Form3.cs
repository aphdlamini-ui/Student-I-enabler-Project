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
    public partial class ModuleRegistration : Form
    {
        private const int CREDITS_PER_MODULE = 16;
        private const int MAX_CREDITS = 160;
        private const decimal COST_PER_MODULE = 4500.00m;

        public ModuleRegistration()
        {
            InitializeComponent();
        }

       
        private void Form3_Load(object sender, EventArgs e)
        {
            // Initialize credit textboxes on form load
            creditsAvaTxtBox.Text = MAX_CREDITS.ToString();
            creditsSelectedTxtBox.Text = "0";

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

            // Update textboxes
            creditsAvaTxtBox.Text = creditsAvailable.ToString();
            creditsSelectedTxtBox.Text = creditsSelected.ToString();

            // Show warning if student exceeds maximum credits
            if (creditsSelected > MAX_CREDITS)
            {
                MessageBox.Show("You have exceeded the maximum credit limit of 160. Please uncheck some modules.",
                    "Credit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void Moduleguidebtn_Click(object sender, EventArgs e)
        {
            ModuleGuideForm f8 = new ModuleGuideForm(this);
            f8.Show();
            this.Hide();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MenuForm"] is MenuForm f2)
            {
                f2.Show();
                this.Close();
            }
            else
            {
                // If MenuForm is not already open, create a new instance
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Close();
            }
        }

        private void Supportlbl_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter your message for support:", "Contact Support", "Type your message here...");
            if (!string.IsNullOrEmpty(input))
            {
                // Here is the code to send the input to support system or email
                MessageBox.Show("Your message has been sent to support.", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            // Uncheck all checkboxes in ModuleGroupBox
            foreach (Control control in ModuleGroupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

            // Reset credit textboxes
            creditsAvaTxtBox.Text = MAX_CREDITS.ToString();
            creditsSelectedTxtBox.Text = "0";
        }

        private void CompleteBtn_Click(object sender, EventArgs e)
        {
            int creditsSelected = int.Parse(creditsSelectedTxtBox.Text);

            // Validate that student has selected enough modules
            if (creditsSelected == 0)
            {
                MessageBox.Show("Please select at least one module.", "No Modules Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that student hasn't exceeded credit limit
            if (creditsSelected > MAX_CREDITS)
            {
                MessageBox.Show("You have exceeded the maximum credit limit of 160. Please uncheck some modules.",
                    "Credit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate number of modules selected
            int modulesSelected = creditsSelected / CREDITS_PER_MODULE;

            // Calculate total cost
            decimal totalCost = modulesSelected * COST_PER_MODULE;

            string registeredModules = "You have successfully registered for the following:\n\n";
            bool anyChecked = false;

            // Dictionary to map checkbox names to their display text
            Dictionary<string, string> moduleMap = new Dictionary<string, string>()
            {
                { "AFNCcheckBox2", "Advance Financial Methods - AFNC212" },
                { "BIAcheckBox1", "Business Information Analysis - BIA24A" },
                { "SADcheckBox3", "System Analysis & Design - SAD3" },
                { "ACCcheckBox5", "Management Accounting - ACC212" },
                { "ECONcheckBox6", "MacroEconomics - ECON212" },
                { "MNGTcheckBox8", "Management - MNGT212" },
                { "HRcheckBox9", "Human Resources - HR212" },
                { "ENTcheckBox10", "Entrepreneurship - ENT212" },
                { "PMGTcheckBox11", "Project Management - PMGT212" },
                { "BMIcheckBox12", "Business Management - BMI212" },
                { "CFcheckBox13", "Corporate Finance - CF212" },
                { "BEcheckBox14", "Business Ethics - BE212" },
                { "TaxcheckBox15", "Taxation - TAX212" },
                { "SPPcheckBox16", "Strategic Planning - SPP212" },
                { "ITcheckBox17", "Information Technology - IT212" },
                { "ISTNcheckBox16", "Information System & Design - ISTN212" },
                { "BIcheckBox15", "Banking & Investent - BI213" },
                { "FcheckBox21", "Finanacial Mathemtics - F201" },
                { "IScheckBox18", "Information Science _ IS214" },
                { "BMcheckBox4", "Business Management - B213" },
                { "EconcheckBox19", "MicroEconomics - ECON2122" }
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

                // Store the total cost and modules count in AppData
                AppData.TotalAmountDue = $"R{totalCost:F2}";
                AppData.RegisteredModulesCount = modulesSelected.ToString();

                // Try to find existing MenuForm instance first
                if (Application.OpenForms["MenuForm"] is MenuForm menuForm)
                {
                    // If it exists, refresh its data and show it
                    menuForm.LoadData(); // Call LoadData to refresh the display
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
                MessageBox.Show("Please select at least one module.", "No Modules Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }
    }
}