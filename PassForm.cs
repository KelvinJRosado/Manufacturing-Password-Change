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
     
        public PassForm()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
           
            if (NewPassTxt.Text != rePassText.Text) {
                MessageBox.Show("The new password and re-entered password do not match!", "New Password Match Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                 //Check the char difference between the current password and the new one
                 int dif_char_Count = char_check(CurrentPassText.Text,NewPassTxt.Text);

                //if there are too little difference display error
                if (dif_char_Count < 3) {

                    MessageBox.Show("The new password must be atleast 3 different characters from previous passwords!", "Password character count error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PassFormcs_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private int char_check(string oldPass, string newPass) {

            char[] newPassChars = newPass.ToArray();
            char[] oldPassChars = oldPass.ToArray();
            int count = 0;
            int i = 0;

            while (i <= newPassChars.Length && i <= oldPassChars.Length) {

                //condition for if new password is shorter than old password
                if (i >= newPassChars.Length && i <= oldPassChars.Length)
                {
                    //count the lack of chars as a difference 
                    count += (oldPassChars.Length - i);
                    return count;

                }

                //condition for if old password is shorter than new password
                if (i <= newPassChars.Length && i >= oldPassChars.Length)
                {
                    
                    count += (newPassChars.Length - i);
                    return count;
                   
                }

                //chech the chars, increment count if they are different
                else if (newPassChars[i] != oldPassChars[i])
                {
                    count++;
                }
               
                i++;
            }
            return count;
        }
    }
}
