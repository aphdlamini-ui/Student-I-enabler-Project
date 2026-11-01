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
    public partial class MenuForm : Form
    {
        int clickCount = 0;
        public MenuForm()
        {
            InitializeComponent();

            label20.Parent = BackgroundImageBox;
            label20.Text = "Welcome to the";
            label20.BackColor = Color.FromArgb(0, 0, 0, 0);
            label20.ForeColor = Color.White;
            label20.BringToFront();
            label20.Location = new Point(273, 92);

            label21.Parent = BackgroundImageBox;
            label21.Text = "Student iEnabler portal";
            label21.BackColor = Color.FromArgb(0, 0, 0, 0);
            label21.ForeColor = Color.White;
            label21.BringToFront();
            label21.Location = new Point(200, 109);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label21.Location = new Point(255, 180);
            LoadData();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        // Central method to load shared data into textboxes - PUBLIC
        public void LoadData()
        {
            FullNameDisplay.Text = AppData.StudentName;
            TotalDueTxtBox.Text = AppData.TotalAmountDue;
            RegisteredMTxtBox.Text = AppData.RegisteredModulesCount;
            PhoneNoBox.Text = AppData.PhoneNumber;

            // Display Student Year (First-Year or Not)
            if (!string.IsNullOrEmpty(AppData.StudentYear))
            {
                StudentYearBox.Text = AppData.StudentYear;
            }
            else
            {
                StudentYearBox.Text = "";
            }

            // Display Registered Modules list
            if (!string.IsNullOrEmpty(AppData.RegisteredModules))
            {
                RegisteredModulesBox.Text = "";
            }
            else
            {
                RegisteredModulesBox.Text = "";
            }
        }

        // Load only phone data when updated
        public void LoadPhoneData()
        {
            PhoneNoBox.Text = AppData.PhoneNumber;
        }

        // Reload all data including year and modules
        public void ReloadMenuForm()
        {
            try
            {
                LoadData();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading form: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewResultbtn_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount == 1)
            {
                ClassMarkbtn.Visible = true;
                FinalMarkbtn.Visible = true;
                ExamMarkbtn.Visible = true;
                ClassPictureBox.Visible = true;
                FinalPictureBox.Visible = true; 
                ExamPictureBox.Visible = true;
            }
            else if (clickCount == 2)
            {
                ClassMarkbtn.Visible = false;
                FinalMarkbtn.Visible = false;
                ExamMarkbtn.Visible = false;
                ClassPictureBox.Visible = false;
                FinalPictureBox.Visible = false;
                ExamPictureBox.Visible = false;
                clickCount = 0;
            }
        }

        private void ClassMarkbtn_Click(object sender, EventArgs e)
        {
            ClassMarkForm form6 = new ClassMarkForm();
            form6.Show();
            this.Hide();
        }

        private void RegisterModulesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you a first year student?", "Choose Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    AppData.StudentYear = "First-Year";
                    FirstYearRegistrationForm form4 = new FirstYearRegistrationForm();
                    form4.Show();
                    this.Hide();
                }
                else if (result == DialogResult.No)
                {
                    AppData.StudentYear = "Not First-Year";
                    ModuleRegistration form3 = new ModuleRegistration();
                    form3.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void ExamMarkbtn_Click(object sender, EventArgs e)
        {
            ExamMarkForm form5 = new ExamMarkForm();
            form5.Show();
            this.Hide();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void UpdateDetailsbtn_Click(object sender, EventArgs e)
        {
            UpdateDetailsForm form7 = new UpdateDetailsForm(this);
            form7.Show();
            this.Hide();
        }

        private void FinalMarkbtn_Click(object sender, EventArgs e)
        {
            FinalMarkForm form8 = new FinalMarkForm();
            form8.Show();
            this.Hide();
        }

        private void SupportEmailLabel_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter your message for support:", "Contact Support", "Type your message here...");
            if (!string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Your message has been sent to support.", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IEnablerReloadbtn_Click(object sender, EventArgs e)
        {
            ReloadMenuForm();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately residence applications are not available");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("If a student requires funding, please visit our website: www.example.com/bursaries");
        }

        private void Resapplicationbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please apply fo residence at www.example.com/residence");
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }
    }
}