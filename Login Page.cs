using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace sprint_2_draft
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void EmployeeLogin_Page_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
           
            try
                {
            string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Login.accdb;";
            OleDbConnection conDataBase = new OleDbConnection(constring);
            OleDbCommand cmdDataBase = new OleDbCommand("Select * from Login where UserName='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "';", conDataBase);
            OleDbDataReader myReader;
           
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count=count+1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successful");

                    Payroll frm = new Payroll();
                    frm.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username or Password");
                }
                else if (count==0)
                {
                    MessageBox.Show("Please enter a valid Username and Password");
                }
                else
                    MessageBox.Show("Username or Password do not match");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Here_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_Here frm = new Register_Here();
            frm.Show();
        }
    }
}
