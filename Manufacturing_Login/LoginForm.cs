using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manufacturing_Login
{
    public partial class LoginForm : Form
    {
        PassForm pForm;
        CompleteForm cForm;
        ErrorForm eForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if ((LoginTxt.Text != "") && (PassText.Text != "") && (MACTest.Text != ""))
            {
                pForm = new PassForm();
                pForm.Show();
            }
            else
            {
                eForm = new ErrorForm();
                eForm.Show();

            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((LoginTxt.Text != "") && (PassText.Text != "") && (MACTest.Text != ""))
                {
                        cForm = new CompleteForm();
                        cForm.Show();

                    if (LoginBtn.Text == "Login")
                    {
                        LoginBtn.Text = "Logging in...";
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    eForm = new ErrorForm();
                    eForm.Show();
                }
            }

            catch (Exception exp)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
