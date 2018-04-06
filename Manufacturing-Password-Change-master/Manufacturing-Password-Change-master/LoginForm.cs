using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace Manufacturing_Password_Change_master
{
    public partial class LoginForm : Form
    {
        //forms to be used in the program
        PassForm pForm;
        CompleteForm cForm;
        ErrorForm eForm;
		DatabaseConnection databaseConnection;

        //password will be the password input from the C# form
        public static string password;
        public static string hash;
        public static bool validPass;


        public LoginForm()
        {
            InitializeComponent();

            //call the password hashing functions
            PasswordHash passHash = new PasswordHash();
			DatabaseConnection connection = new DatabaseConnection();
			password = PassText.Text;
            hash = PasswordHash.CreateHash(password);
            bool validPass = PasswordHash.ValidatePassword(password, hash);
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            password = PassText.Text;

            //makes sure that the fields are filled
            if ((LoginTxt.Text != "") && (PassText.Text != "") && (MACTest.Text != ""))
            {
                //makes sure there is only one passform instantiation
                if (PassForm.instantiations == 0)
                {
                    pForm = new PassForm();
                    pForm.Show();
                    timer1.Enabled = true;
                    
                }
            }
            else
            {
                //makes sure there is only one errorform instantiation
                if (ErrorForm.instantiations == 0)
                {
                    eForm = new ErrorForm();
                    eForm.Show();
                    timer1.Enabled = true;
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //makes sure that the fields are filled
                if ((LoginTxt.Text != "") && (PassText.Text != "") && (MACTest.Text != ""))
                {
                    //makes sure there is only one completeform instantiation
                    if (CompleteForm.instantiations == 0)
                    {
                        cForm = new CompleteForm();
                        cForm.Show();
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    //makes sure there is only one errorform instantiation
                    if (ErrorForm.instantiations == 0)
                    {
                        eForm = new ErrorForm();
                        eForm.Show();
                        timer1.Enabled = true;
                    }
                }
            }

            catch (Exception exp)
            {

            }
        }

        //timer tick is empty for now, don't really know if we need to put anything in here
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

		private String getMacFormatted()
		{
			//Get raw MAC address
			String mac = NetworkInterface.GetAllNetworkInterfaces()
			.Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
			.Select(nic => nic.GetPhysicalAddress().ToString())
			.FirstOrDefault();

			//Put MAC address in proper format
			String macFormat = "";
			for(int i = 0; i < mac.Length; i++)
			{
				if(i % 2 == 0)
				{
					macFormat += mac[i];
				}
				else
				{
					macFormat += mac[i] + "-";
				}
			}
			macFormat = macFormat.Substring(0, macFormat.Length - 1);

			return macFormat;

		}
    }
}
