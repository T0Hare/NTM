using System;
using System.Data.SqlClient;
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
    public partial class QuizPage : Form
    {
        public string quizname;
        public int useramount = 0;
        public bool rightcheck = false;
        public int tempimageint = 0;
        public string textboxstring;
        public Image Blank = NTM_V4.Properties.Resources.Blank;      
        public bool unused = false;
        public Boolean Timeroncheck = false;
        public double countdowncount = 60;
        public int counter1 = 0;
        public bool timerend = false;
        Homepage info = new Homepage();
        public Image[] Alkanes = new Image[10];
        public Image[] Imagesused = new Image[10];
        private int alkanecode;

        public QuizPage()
        {
            InitializeComponent();
        }
        public QuizPage(ref int type, ref int id)
        {

        }      
        public int Type
        {
            get { return this.info.questtype; }
            set { this.info.questtype = value; }
        }
        public int id
        { 
            get { return this.info.questID; }
            set { this.info.questID = value; }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addAlkaneINFO()
        {
            quizname = "alkanes";
            Alkanes[0] = NTM_V4.Properties.Resources.Methane;
            Alkanes[1] = NTM_V4.Properties.Resources.ethane;
            Alkanes[2] = NTM_V4.Properties.Resources.Propane;
            Alkanes[3] = NTM_V4.Properties.Resources.Butane;
            Alkanes[4] = NTM_V4.Properties.Resources.pentane;
            Alkanes[5] = NTM_V4.Properties.Resources.Hexane;
            Alkanes[6] = NTM_V4.Properties.Resources.Heptane;
            Alkanes[7] = NTM_V4.Properties.Resources.octane;
            Alkanes[8] = NTM_V4.Properties.Resources.nonane;
            Alkanes[9] = NTM_V4.Properties.Resources.decane;           
        }

        private void QuizPage_Shown(object sender, EventArgs e)
        {
            string[] OutterQuizNames = new string[6];
            string quiztext = "";
            string filetext;
            if (Type == 0)
            {
                CustomQbox.Show();
            }
            else if (Type == 1)
            {
                listBox1.Show(); listBox2.Show(); listBox3.Show(); listBox4.Show();
                No1LBL.Show(); No2LBL.Show(); No3LBL.Show(); No4LBL.Show();
            }
            else
            {

            }                                 
            choosequiz();
            using (StreamReader filename = new StreamReader("Past 5 quizes.txt", true))
            {
                filetext = filename.ReadToEnd();
                string[] Quiznames = filename.ReadToEnd().Split(',');
                string[] Quiznames1 = Quiznames[0/*To be user ID */].Split(' ');
                OutterQuizNames = Quiznames1;
                for (int count = 0; count < useramount; count++)
                {
                    if (OutterQuizNames[count] != "-")
                    {
                        if (count == 4)
                        {
                            OutterQuizNames[0] = quizname;
                        }
                        else
                        {
                            OutterQuizNames[count] = quizname;
                            //QuizNameLBL.Text =
                        }
                    }
                }
                for (int count = 0; count < useramount; count++)
                {
                    quiztext = quiztext + OutterQuizNames[count];
                }
            }
            QuizNameLBL.Text = quiztext;
            QuestionBox.Image = Imagesused[tempimageint];          
            unused = true; counterchange(); resettimer();
            timerdown();
        }

        private void QuizPage_Load(object sender, EventArgs e)
        {
            
        }
        public void Tests()
        {
            /*
            Homepage home = new Homepage();
            int questID = home.QuestID;
            string SentQuizID = questID.ToString();   
            
            string connecstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=LocalDBNTMV4;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connect = new SqlConnection(connecstring);
            connect.Open();

            string sqlQRY = "SELECT QuizTableName FROM QuizInfo WHERE Id = 2";
            SqlCommand cmd = new SqlCommand(sqlQRY, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                string sqlQRY2 = "SELECT Resource string FROM " + reader["QuizTableName"].ToString() + "WHERE Id =  3";
                SqlCommand cmd2 = new SqlCommand(sqlQRY2, connect);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                if (reader2.HasRows)
                {
                    string resstring;
                    resstring = reader2["Resource string"].ToString();
                    Image[] img = new Image[2];
                    var ResourceManager =
                    new System.Resources.ResourceManager(resstring, typeof(Properties.Resources).Assembly);
                    QuestionBox.Image = img[0];
                }
                else
                {
                    QuizNameLBL.Text = "NO";
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
            */
            switch (id)
            {
                case 0:
                    {
                        //QuestionBox.Image = NTM_V4.Properties.Resources.AL_TO_COOH_CON;
                    }
                    break;
                case 1:
                    {
                        QuestionBox.Image = NTM_V4.Properties.Resources.AL_TO_COOH_REA;
                    }
                    break;
                case 2:
                    {
                        QuestionBox.Image = NTM_V4.Properties.Resources.AL_TO_COOH_PROD;
                    }
                    break;
                case 3:
                    {
                        QuestionBox.Image = NTM_V4.Properties.Resources.AL_TO_OH_REA;
                    }
                    break;
                case 4:
                    {
                        QuestionBox.Image = NTM_V4.Properties.Resources.ANE_to_ENE_CON;
                    }
                    break;
                case 5:
                    {
                        QuestionBox.Image = NTM_V4.Properties.Resources.ANE_TO_ENE_PROD;
                    }
                    break;
                case 6:
                    {
                        QuestionBox.Image = NTM_V4.Properties.Resources.Blank;
                    }
                    break;
            }
        }
        
        public void timerdown()
        {
            if (Timeroncheck == true)
            {
                Timer.Enabled = false;
                Timer.Stop();
                countdowncount = 60;
                Timecountdown.Text = countdowncount.ToString();
                Timer.Enabled = true;
                Timer.Start();
                Timer.Interval = 1000;
            }
            else
            {
                Timer.Enabled = true;
                Timer.Start();
                Timer.Interval = 1000;
                Timer.Tick += new EventHandler(timerout_Tick);
            }
        }
        public void timerout_Tick(object sender, EventArgs e)
        {
            at0();
            Timeroncheck = true;
            countdowncount = countdowncount - 1;
            Timecountdown.Text = countdowncount.ToString();
            if (countdowncount == 0)
            {
                Timer.Enabled = false;
                Timer.Stop();
                counter1 = 0;
                Timecountdown.Text = counter1.ToString();
            }
        }
        public void counterchange()
        {
            counter1++;
            Timecountdown.Text = counter1.ToString();
        }
        public void at0()
        {

            if (countdowncount <= 60)
            {
                Timecountdown.ForeColor = Color.Black;
            }
            if (countdowncount <= 30)
            {
                Timecountdown.ForeColor = Color.Yellow;
            }
            if (countdowncount <= 10)
            {
                Timecountdown.ForeColor = Color.Red;
            }
            if (countdowncount <= 0)
            {
                timerend = true;
            }
        }

        public void choosequiz()
        {
            List<int> Codelist = new List<int>();
            using (StreamReader coderetreive = new StreamReader("maxcodes.txt", true))
            {
                string codeasstring = coderetreive.ReadToEnd().ToString();
                int codesasint = int.Parse(codeasstring);
                for (int count = 0; count < codesasint; count++)
                {
                    Codelist.Add(codesasint - count);
                }              
            }
            if (id <= Codelist.Max() && id > -1)
            {
                if (id < 14)
                {
                    switch (id)
                    {
                       case 0:
                            {
                                addAlkaneINFO();
                                Imagesused = Alkanes;
                            }
                            break;
                       case 1:
                            {
                                
                            }
                            break;
                        case 2:
                            {

                            }
                            break;
                        case 3:
                            {

                            }
                            break;
                        case 4:
                            {

                            }
                            break;
                        case 5:
                            {

                            }
                            break;
                        case 6:
                            {

                            }
                            break;
                        case 7:
                            {

                            }
                            break;
                        case 8:
                            {

                            }
                            break;
                        case 9:
                            {

                            }
                            break;
                        case 10:
                            {

                            }
                            break;
                        case 11:
                            {

                            }
                            break;
                        case 12:
                            {

                            }
                            break;
                        case 13:
                            {

                            }
                            break;
                        case 14:
                            {

                            }
                            break;                        
                    }
                    
                }
                
            }
        }        

        public void resettimer()
        {
            Timer.Enabled = false;
            Timer.Stop();
            countdowncount = 60;
            Timecountdown.Text = countdowncount.ToString();
        }
        private void QuizPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Homepage().Show();
        }


        private void CheckBUT_Click(object sender, EventArgs e)
        {           
            textboxstring = CustomQbox.Text.ToString();
            checkdefaultquizes();
            moveoncheck();
            CustomQbox.Text = "";
        }
        public void moveoncheck()
        {
            if (rightcheck == true)
            {               
                if (tempimageint <= 8)
                {
                    rightcheck = false;
                    tempimageint = tempimageint + 1;
                    QuestionBox.Image = Imagesused[tempimageint];                  
                }
                else
                {                                                                         
                    using (StreamWriter filename = new StreamWriter("Past 5 quizes.txt", true))
                    {                       
                        
                    }
                    //new Homepage().Show();
                    // Hide();
                }
            }
        }
        public void checkdefaultquizes()
        {
            for (int count = 0; count < 10; count++)
            {
                if (QuestionBox.Image == Alkanes[count])
                {
                    alkaneanswercheck();
                }
            }
        }
        public void alkaneanswercheck()
        {
            switch (tempimageint)
            {
                case 0:
                    {
                        if (textboxstring.ToUpper() == "METHANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange(); resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was methane";
                        }
                    }
                    break;
                case 1:
                    {
                        if (textboxstring.ToUpper() == "ETHANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange();resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was ethane";
                        }
                    }
                    break;
                case 2:
                    {
                        if (textboxstring.ToUpper() == "PROPANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange();resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was propane";
                        }
                    }
                    break;
                case 3:
                    {
                        if (textboxstring.ToUpper() == "BUTANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange(); resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was butane";
                        }
                    }
                    break;
                case 4:
                    {
                        if (textboxstring.ToUpper() == "PENTANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange(); resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was pentane";
                        }
                    }
                    break;
                case 5:
                    {
                        if (textboxstring.ToUpper() == "HEXANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange();resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was hexane";
                        }
                    }
                    break;
                case 6:
                    {
                        if (textboxstring.ToUpper() == "HEPTANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange();  resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was heptane";
                        }
                    }
                    break;
                case 7:
                    {
                        if (textboxstring.ToUpper() == "OCTANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange(); resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was octane";
                        }
                    }
                    break;
                case 8:
                    {
                        if (textboxstring.ToUpper() == "NONANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange(); resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was nonane";
                        }
                    }
                    break;
                case 9:
                    {
                        if (textboxstring.ToUpper() == "DECANE")
                        {
                            RightWrongDisplay.Text = "Right! - Well done";
                            unused = true;
                            counterchange(); resettimer();
                            timerdown();
                            rightcheck = true;
                        }
                        else
                        {
                            RightWrongDisplay.Text = "Wrong - The answer was decane";
                        }
                    }
                    break;
            }
        }
      
    }
}
