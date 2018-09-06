using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NTM_V4
{
    public partial class RetreivePassForm : Form
    {
        public RetreivePassForm()
        {
            InitializeComponent();
        }

        private void RecBut_Click(object sender, EventArgs e)
        {
            //Recovering the given code from a text file and respomding with the username and password of the account
            int typecount = 0;
            using (StreamReader filename = new StreamReader("AccountRecoveryCodes.txt", true))
            {               
                int lines;               
                lines = File.ReadLines(@"AccountRecoveryCodes.txt").Count();
                string[] ARCs = new string[lines];
                for (int count = 1; count < lines; count++)
                {
                    if (RecBox.Text == ARCs[count])
                    {
                        typecount = count;
                        using (StreamReader filename2 = new StreamReader("names.txt", true))
                        {
                            int lines1;
                            lines1 = File.ReadLines(@"names.txt").Count();
                            string[] names = new string[lines1];
                            UsernameLBL.Text = names[typecount];
                        }
                        using (StreamReader filename3 = new StreamReader("passwords.txt", true))
                        {
                            int lines2;
                            lines2 = File.ReadLines(@"passwords.txt").Count();
                            string[] passwords = new string[lines2];
                            PasswordLBL.Text = passwords[typecount];
                        }
                    }
                }               
            }           
        }

        private void RetreivePassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Opening the log in form
            new Form1().Show();
        }
    }
}
