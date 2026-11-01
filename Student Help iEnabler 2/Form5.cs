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
    public partial class ExamMarkForm : Form
    {
        private readonly System.Windows.Forms.ToolTip toolTip1;
        public ExamMarkForm()
        {
            InitializeComponent();

            toolTip1 = new System.Windows.Forms.ToolTip
            {
                AutoPopDelay = 0,
                InitialDelay = 0,
                ReshowDelay = 0,
                ShowAlways = false
            };
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MenuForm"] is MenuForm f2)
            {
                f2.Show();
                this.Close();
            }
        }

        private void MgShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 54;

            MgTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", MgTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", MgTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", MgTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", MgTbx, 3000);
            }
        }

        private void BsShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 43;

            BsTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", BsTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", BsTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", BsTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", BsTbx, 3000);
            }
        }

        private void AcShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 67;

            AcTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", AcTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", AcTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", AcTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", AcTbx, 3000);
            }
        }

        private void MtShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 41;

            MtTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", MtTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", MtTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", MtTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", MtTbx, 3000);
            }
        }

        private void FnShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 72;

            FnTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", FnTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", FnTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", FnTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", FnTbx, 3000);
            }
        }

        private void StShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 81;

            StTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", StTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", StTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", StTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", StTbx, 3000);
            }
        }

        private void TcShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 94;

            TcTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", TcTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", TcTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", TcTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", TcTbx, 3000);
            }
        }

        private void LwShowMrk_Click(object sender, EventArgs e)
        {
            double classMark = 79;

            LwTbx.Text = classMark.ToString();

            if (classMark > 75)
            {
                toolTip1.Show("Passed with Distinction", LwTbx, 3000);
            }
            else if (classMark >= 60)
            {
                toolTip1.Show("Great Performance", LwTbx, 3000);
            }
            else if (classMark >= 50)
            {
                toolTip1.Show("Average Performance", LwTbx, 3000);
            }
            else
            {
                toolTip1.Show("Failed", LwTbx, 3000);
            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }
    }
}
