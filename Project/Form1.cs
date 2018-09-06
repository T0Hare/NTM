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
    public partial class Form1 : Form
    {
        public int Userid;
        private bool Usertruth = false;
        private bool Passtruth = false;
        public Form1()
        {
            InitializeComponent();
        }

        public bool usertruth
        {
            get { return this.Usertruth; }
            set { this.Usertruth = value; }
        }

        public bool passtruth
        {
            get { return this.Passtruth; }
            set { this.Passtruth = value; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LogInBut_Click(object sender, EventArgs e)
        {
            //Testing to see if the username and password is correct from the default name and pass or from a text file          
            string defaultname;
            defaultname = "name";
            string defaultpassword;
            defaultpassword = "password";
            if (Userbox.Text == defaultname || PassBox.Text == defaultpassword)
            {
                new Homepage().Show();
                Hide();
            }       
            else
            {
                
            }
            using (StreamReader filename = new StreamReader("names.txt", true))
            {
                int lines;
                lines = File.ReadLines(@"names.txt").Count();
                string[] names = new string[lines];
                names = filename.ReadLine().Split(',');               
                for (int count = 1; count < names.Length;count++)
                {                 
                    if (Userbox.Text == names[count])
                    {
                        Usertruth = true;
                        Userid = count;
                    }
                }
            }
            using (StreamReader filename = new StreamReader("passwords.txt", true))
            {
                int lines;
                lines = File.ReadLines(@"passwords.txt").Count();
                string[] passwords = new string[lines];
                passwords = filename.ReadLine().Split(',');               
                for (int count = 0;count < passwords.Length;count++)
                {
                    if (PassBox.Text == passwords[count])
                    {
                        Passtruth = true;
                    }
                }              
            }
            if (Usertruth == true && Passtruth == true)
            {
                new Homepage().Show();
                Hide();
            }
            else
            {
                LogResult.Visible = true;
                LogResult.Text = "Please enter correct details";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreateAccountForm().Show();
            Hide();
        }

        private void RetreivePassBut_Click(object sender, EventArgs e)
        {
            new RetreivePassForm().Show();
            Hide();
        }
    }
}
