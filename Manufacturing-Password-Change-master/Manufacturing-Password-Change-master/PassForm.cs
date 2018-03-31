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
    public partial class PassForm : Form
    {
        public static int instantiations = 0;
        public PassForm()
        {
            InitializeComponent();
            instantiations++;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if(CurrentPassText.Text == LoginForm.password)
            {
                LoginForm.password = NewPassTxt.Text;
                MessageBox.Show(LoginForm.password);
            }
        }

        private void PassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instantiations--;
        }
    }
}
