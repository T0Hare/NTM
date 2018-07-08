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
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            
            
        }       

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ALkanesBUT_Click(object sender, EventArgs e)
        {
            string connecstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=LocalDBNTMV4;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connect = new SqlConnection(connecstring);
            connect.Open();
            string sqlQRY = "SELECT Name FROM Alkanes WHERE Id = 2";
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
        }

        private void AlkenesBUT_Click(object sender, EventArgs e)
        {

        }

        private void HAlkanesBUT_Click(object sender, EventArgs e)
        {

        }

        private void KetonesBUT_Click(object sender, EventArgs e)
        {

        }

        private void COOHBUT_Click(object sender, EventArgs e)
        {

        }

        private void EstersBUT_Click(object sender, EventArgs e)
        {

        }

        private void Reactions_Click(object sender, EventArgs e)
        {

        }

        private void G2BUT_Click(object sender, EventArgs e)
        {

        }

        private void G17TBUT_Click(object sender, EventArgs e)
        {

        }

        private void P3BUT_Click(object sender, EventArgs e)
        {

        }

        private void AdvMolBUT_Click(object sender, EventArgs e)
        {

        }

        private void AdvTrendBUT_Click(object sender, EventArgs e)
        {

        }

        private void MYOQLBL_Click(object sender, EventArgs e)
        {

        }

        private void EasyTailorBUT_Click(object sender, EventArgs e)
        {

        }

        private void MediumTailorBUT_Click(object sender, EventArgs e)
        {

        }

        private void HardTailorBUT_Click(object sender, EventArgs e)
        {

        }

        private void EnterMultiBUT_Click(object sender, EventArgs e)
        {

        }
    }
}
