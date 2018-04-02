using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manufacturing_Password_Change_master
{
    public partial class CompleteForm : Form
    {
        public static int instantiations = 0;
        public CompleteForm()
        {
            InitializeComponent();
            instantiations++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CompleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instantiations--;
            
        }
    }
}
