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
    public partial class CreateQuizForm : Form
    {
        OpenFileDialog boop = new OpenFileDialog();      
        public CreateQuizForm()
        {           
            InitializeComponent();          
        }              

        private void RecBut_Click(object sender, EventArgs e)
        {
            //Opening the file selection dialog and showing the file name of the selected file
            if (boop.ShowDialog() == DialogResult.OK)
            {             
                //label4.Text = System.IO.Path.GetFileName(boop.FileNames.ToString());
                string[] Filenames = boop.FileNames;
                string completenames = "";
                for (int count = 0;count < Filenames.Length;count++)
                {
                    completenames = completenames + Filenames[count];
                }
                label4.Text = completenames;
            }
            else
            {
                label4.Text = "ERROR";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void CreateQuizForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Going back to the main menu
            new Homepage().Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {                    

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void CreateQuizForm_Load(object sender, EventArgs e)
        {
            //Enabling multiselect
            boop.Multiselect = true;
        }
    }
}
