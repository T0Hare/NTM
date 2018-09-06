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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void LogInBut_Click(object sender, EventArgs e)
        {
            bool truth;
            truth = false;
            char[] passboxarray = CreatePassBox.Text.ToCharArray();
            char[] specialchars = new char[] {'"','!','£','$','%','^','&','*','(',')','_','-','+','=','|','{','}','[',']',':',';','@','#','~','<','>',',','.','?','/' };
            if (CreateUserBox.Text.ToString().Length > 3 & CreateUserBox.Text.ToString() != "" & CreatePassBox.Text.ToString().Length > 4 & RepeatPassBox.Text.ToString() == CreatePassBox.Text & CreateAcctRecBox.Text.ToString() != "" & CreateAcctRecBox.Text.ToString().Length > 4)
            {
                truth = true;
            }
            else
            {
                ErrorLbl.Text = "Please enter the correct details";
            }
            
            for (int count = 0; count < CreatePassBox.Text.Length; count++)
            {
                for (int count2 = 0; count2 < specialchars.Length; count2++)
                {
                    if (passboxarray[count] == specialchars[count2])
                    {
                        truth = true;
                    }
                }
            }
            
            if (truth == true)
            {
                int filelines;
                using (StreamReader filename = new StreamReader("names.txt", true))
                {
                    filelines = File.ReadLines(@"names.txt").Count();
                }
                using (StreamWriter filename = new StreamWriter("names.txt", true))
                {                                                         
                      filename.Write(CreateUserBox.Text + ".");                    
                }
                using (StreamReader filename = new StreamReader("passwords.txt", true))
                {
                    filelines = File.ReadLines(@"passwords.txt").Count();
                }
                using (StreamWriter filename = new StreamWriter("passwords.txt", true))
                {
                    filename.Write(CreatePassBox.Text + ",");
                }
                using (StreamReader filename = new StreamReader("AccountRecoveryCodes.txt", true))
                {
                    filelines = File.ReadLines(@"AccountRecoveryCodes.txt").Count();
                }
                using (StreamWriter filename = new StreamWriter("AccountRecoveryCodes.txt", true))
                {
                    filename.Write(CreateAcctRecBox.Text + ",");
                }
                new Form1().Show();
                Hide();
            }
            else
            {
                ErrorLbl.Text = "Please enter the correct details";               
            }            
        }
    }
}
