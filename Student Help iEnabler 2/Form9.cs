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
    public partial class FinalMarkForm : Form
    {
        private readonly System.Windows.Forms.ToolTip toolTip1;

        public FinalMarkForm(System.Windows.Forms.ToolTip toolTip1)
        {
            this.toolTip1 = toolTip1;
        }

        public FinalMarkForm()
        {
            InitializeComponent();
            toolTip1 = new System.Windows.Forms.ToolTip();
        }

        

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MenuForm"] is MenuForm f2)
            {
                f2.Show();
                this.Close();
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void EconShowMarkButton_Click(object sender, EventArgs e)
        {
            double dpMark = 67;
            double examMark = 85;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            EcontextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                EconTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                EconTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                EconTextBoxComment.Text = "Special Exam required";
            else
                EconTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", EconTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", EconTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", EconTextBoxComment, 3000);
        }

        private void MgntShowmarkButton_Click(object sender, EventArgs e)
        {
            double dpMark = 58;
            double examMark = 54;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            MgntTextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                MgntTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                MgntTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                MgntTextBoxComment  .Text = "Special Exam required";
            else
                MgntTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", MgntTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", MgntTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", MgntTextBoxComment, 3000);
        }

        private void BsnsShowMarkButton_Click(object sender, EventArgs e)
        {
            double dpMark = 50;
            double examMark =43 ;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            BsnsTextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                BsnsTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                BsnsTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                BsnsTextBoxComment.Text = "Special Exam required";
            else
                BsnsTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", BsnsTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", BsnsTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", BsnsTextBoxComment, 3000);
        }

        private void AcctShowMarkButton_Click(object sender, EventArgs e)
        {
            double dpMark = 59;
            double examMark = 67;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            AcctTextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                AcctTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                AcctTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                AcctTextBoxComment.Text = "Special Exam required";
            else
                AcctTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", AcctTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", AcctTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", AcctTextBoxComment, 3000);
        }

        private void MthsShowMarkButton_Click(object sender, EventArgs e)
        {
            double dpMark = 47;
            double examMark = 41;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            MthsTextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                MthsTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                MthsTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                MthsTextBoxComment.Text = "Special Exam required";
            else
                MthsTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", MthsTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", MthsTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", MthsTextBoxComment, 3000);
        }

        private void FincShowMarkButton_Click(object sender, EventArgs e)
        {
            double dpMark = 64;
            double examMark = 72;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            FincTextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                FincTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                FincTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                FincTextBoxComment.Text = "Special Exam required";
            else
                FincTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", FincTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", FincTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", FincTextBoxComment, 3000);
        }

        private void StatsShowMarkButton_Click(object sender, EventArgs e)
        {
            double dpMark = 84;
            double examMark = 81;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            StatsTextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                StatsTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                StatsTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                StatsTextBoxComment.Text = "Special Exam required";
            else
                StatsTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", StatsTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", StatsTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", StatsTextBoxComment, 3000);
        }

        private void TechnShowButton_Click(object sender, EventArgs e)
        {
            double dpMark = 79;
            double examMark = 94;

            double finalMark = (dpMark * 0.5) + (examMark * 0.5);

            TechnTextBoxMark.Text = finalMark.ToString();

            if (finalMark >= 75)
                TechnTextBoxComment.Text = "Outstanding performance";
            else if (finalMark >= 50)
                TechnTextBoxComment.Text = "Good performance";
            else if (finalMark >= 40)
                TechnTextBoxComment.Text = "Special Exam required";
            else
                TechnTextBoxComment.Text = "Failed";
            if (finalMark > 50)
                toolTip1.Show("Module Passed", TechnTextBoxComment, 3000);
            else if (finalMark >= 40)
                toolTip1.Show("Supplementary Exam Granted", TechnTextBoxComment, 3000);
            else
                toolTip1.Show("Module Failed", TechnTextBoxComment, 3000);
       
        }
    }
}
