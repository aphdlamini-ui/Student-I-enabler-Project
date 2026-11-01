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
    public partial class ClassMarkForm : Form
    {
        private readonly System.Windows.Forms.ToolTip toolTip1;

        public ClassMarkForm()
        {
            InitializeComponent();
            toolTip1 = new System.Windows.Forms.ToolTip(); ;
        }

     

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void PreviouBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MenuForm"] is MenuForm f2)
            {
                f2.Show();
                this.Close();
            }
        }

        private void DpMgntMsgTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void T2FincTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void MgntShowMarksBtn_Click(object sender, EventArgs e)
        {
            double test1 = 67;
            double test2 = 49;


            T1MgntTbx.Text = test1.ToString();
            T2MgntTbx.Text = test2.ToString();

            AgroMgntTbx.Text = "N/A";


            double dpMark = (test1 * 0.5) + (test2 * 0.5);

            DpMgntTbx.Text = dpMark.ToString();


            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;


            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpMgntTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpMgntTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpMgntTbx, 3000);
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
        
        }

        private void BsnsShowMarksBtn_Click_1(object sender, EventArgs e)
        {
            double test1 = 51;
            double test2 = 49;


            T1BsnsTbx.Text = test1.ToString();
            T2BsnsTbx.Text = test2.ToString();

            AgroBsnsTbx.Text = "N/A";


            double dpMark = (test1 * 0.5) + (test2 * 0.5);

            DpBsnsTbx.Text = dpMark.ToString();


            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;


            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpBsnsTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpBsnsTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpBsnsTbx, 3000);
            }
        }

        private void AcctShowMarksBtn_Click_1(object sender, EventArgs e)
        {
            double test1 = 67;
            double test2 = 45;
            double test3 = 51;


            T1AcctTbx.Text = test1.ToString();
            T2AcctTbx.Text = test2.ToString();
            T3AcctTbx.Text = test3.ToString();


            double highest1, highest2;

            if (test1 <= test2 && test1 <= test3)
            {
                highest1 = test2;
                highest2 = test3;
            }
            else if (test2 <= test1 && test2 <= test3)
            {
                highest1 = test1;
                highest2 = test3;
            }
            else
            {
                highest1 = test1;
                highest2 = test2;
            }

            double dpMark = (highest1 * 0.5) + (highest2 * 0.5);

            DpAcctTbx.Text = dpMark.ToString();

            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpAcctTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpAcctTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpAcctTbx, 3000);
            }
        }

        private void MathsShowMarksBtn_Click_1(object sender, EventArgs e)
        {
            double test1 = 55;
            double test2 = 39;


            T1MthsTbx.Text = test1.ToString();
            T2MthsTbx.Text = test2.ToString();

            AgroMthsTbx.Text = "N/A";


            double dpMark = (test1 * 0.5) + (test2 * 0.5);

            DpMthsTbx.Text = dpMark.ToString();


            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;


            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpMthsTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpMthsTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpMthsTbx, 3000);
            }
        }

        private void TechnShowMarksBtn_Click_1(object sender, EventArgs e)
        {
            double test1 = 85;
            double test2 = 73;


            T1TechnTbx.Text = test1.ToString();
            T2TechnTbx.Text = test2.ToString();

            AgroTechnTbx.Text = "N/A";


            double dpMark = (test1 * 0.5) + (test2 * 0.5);

            DpTechnTbx.Text = dpMark.ToString();


            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;


            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpTechnTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpTechnTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpTechnTbx, 3000);
            }
        
        }

        private void FincShowMarksBtn_Click_1(object sender, EventArgs e)
        {
            double test1 = 61;
            double test2 = 67;


            T1FincTbx.Text = test1.ToString();
            T2FincTbx.Text = test2.ToString();

            AgroFincTbx.Text = "N/A";


            double dpMark = (test1 * 0.5) + (test2 * 0.5);

            DpFincTbx.Text = dpMark.ToString();


            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;


            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpFincTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpFincTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpFincTbx, 3000);
            }
        }

        private void StatsShowMarksBtn_Click_1(object sender, EventArgs e)
        {
            double test1 = 73;
            double test2 = 67;
            double test3 = 95;


            T1StatsTbx.Text = test1.ToString();
            T2StatsTbx.Text = test2.ToString();
            T3StatsTbx.Text = test3.ToString();


            double highest1, highest2;

            if (test1 <= test2 && test1 <= test3)
            {
                highest1 = test2;
                highest2 = test3;
            }
            else if (test2 <= test1 && test2 <= test3)
            {
                highest1 = test1;
                highest2 = test3;
            }
            else
            {
                highest1 = test1;
                highest2 = test2;
            }

            double dpMark = (highest1 * 0.5) + (highest2 * 0.5);

            DpStatsTbx.Text = dpMark.ToString();

            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpStatsTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpStatsTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpStatsTbx, 3000);
            }
        }

        private void LawsShowMarksBtn_Click_1(object sender, EventArgs e)
        {
            double test1 = 90;
            double test2 = 75;
            double test3 = 78;


            T1LawsTbx.Text = test1.ToString();
            T2LawsTbx.Text = test2.ToString();
            T3LawsTbx.Text = test3.ToString();


            double highest1, highest2;

            if (test1 <= test2 && test1 <= test3)
            {
                highest1 = test2;
                highest2 = test3;
            }
            else if (test2 <= test1 && test2 <= test3)
            {
                highest1 = test1;
                highest2 = test3;
            }
            else
            {
                highest1 = test1;
                highest2 = test2;
            }

            double dpMark = (highest1 * 0.5) + (highest2 * 0.5);

            DpLawsTbx.Text = dpMark.ToString();

            if (dpMark >= 50)
            {
                toolTip1.Show("Exam Granted", DpLawsTbx, 3000);
            }
            else if (dpMark >= 40)
            {
                toolTip1.Show("Appeal for Exam", DpLawsTbx, 3000);
            }
            else
            {
                toolTip1.Show("Exam Denied", DpLawsTbx, 3000);
            }
        }
    }
}
