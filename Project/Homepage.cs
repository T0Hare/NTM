using System;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTM_V4
{
    public partial class Homepage : Form
    {
        //            
        private int QuestID;
        private int QuestType;     

        public Homepage()
        {
            InitializeComponent();            
        }
        public Homepage(int questID,int questtype,Homepage info)
        {

        }
        public int questID
        {
            get { return this.QuestID; }
            set { this.QuestID = value; }
        }
        public int questtype
        {
            get { return this.QuestType; }
            set { this.QuestType = value; }
        }       
        private void Homepage_Load(object sender, EventArgs e)
        {
            questtype = 1;
            /*
            //Testing to see if any database connection can be made
            string connecstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=LocalDBNTMV4;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connect = new SqlConnection(connecstring);
            connect.Open();
            string sqlQRY = "SELECT Name FROM Alkanes WHERE Id = 1";
            SqlCommand cmd = new SqlCommand(sqlQRY, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                WelcomeLabel.Text = reader["Name"].ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }   
            */
        }       

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Showing the login form
            new Form1().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void ALkanesBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form           
            questID = 1;
            questtype = 1;
            new QuizPage().Show();
            Hide();
        }

        private void AlkenesBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 2;
            questtype = 1;           
            new QuizPage().Show();
            Hide();
        }

        private void HAlkanesBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 3;
            questtype = 1;
            new QuizPage().Show();
            Hide();
        }

        private void KetonesBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 4;
            questtype = 1;
            new QuizPage().Show();
            Hide();
        }

        private void COOHBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 5;
            questtype = 1;
            new QuizPage().Show();
            Hide();
        }

        private void EstersBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 6;
            questtype = 1;
            new QuizPage().Show();
            Hide();
        }

        private void Reactions_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 7;
            questtype = 1;
            new QuizPage().Show();
            Hide();
        }

        private void G2BUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 8;
            questtype = 0;
            new QuizPage().Show();
            Hide();
        }

        private void G17TBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 9;
            questtype = 0;
            new QuizPage().Show();
            Hide();
        }

        private void P3BUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 10;
            questtype = 0;
            new QuizPage().Show();
            Hide();
        }

        private void AdvMolBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 10;
            questtype = 0;
            new QuizPage().Show();
            Hide();
        }

        private void AdvTrendBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 11;
            questtype = 1;
            new QuizPage().Show();
            Hide();
        }

        private void MYOQLBL_Click(object sender, EventArgs e)
        {
            //Opening the custom quiz making form 
            new CreateQuizForm().Show();
            Hide();
        }

        private void EasyTailorBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 12;
            questtype = 0;
            new QuizPage().Show();
            Hide();
        }

        private void MediumTailorBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 13;
            questtype = 0;
            new QuizPage().Show();
            Hide();
        }

        private void HardTailorBUT_Click(object sender, EventArgs e)
        {
            //Carrying QuizID and Quiz type to quiz control, then showing the quiz form
            questID = 14;
            questtype = 0;
            new QuizPage().Show();
            Hide();
        }

        private void CustomGOBUT_Click(object sender, EventArgs e)
        {
            //Retreiving the quiz code and opening the quiz form
            string questcode;
            questcode = CustomQbox.Text;        
            new QuizPage().Show();
            Hide();
        }
    }
}
