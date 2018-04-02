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
        //list of old passwords for testing purposes
        List<String> old_Password = new List<String>();

        

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

            //add the current password to the old passwords array since we are changing it
            old_Password.Add(CurrentPassText.Text);

            //iterate through old passwords and call the char check function on each one
            for (int i = 0; i < old_Password.Count; i++) {

                 int dif_char_Count = char_check(old_Password[i],NewPassTxt.Text);

                //if there are too little difference display error
                if (dif_char_Count < 3) {
                    MessageBox.Show("The new password must be atleast 3 different characters from previous passwords!", "Password character count error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
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
