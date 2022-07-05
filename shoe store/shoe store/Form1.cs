using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace shoe_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.username = "Guest";
            dashboard ds = new dashboard("Guest");
            MessageBox.Show("Welcome Guest! Without Registration you can only be able to view the menu but can not view your cart!!\n\n Have a Good Day");
            ds.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //login code
            //int user_ID;
            
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();            
            cmd.Connection = conn;            
            cmd.CommandText = "select username, password from users where username = '" + usernametxt.Text +"'and password = '" + passTxt.Text + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            

            if (string.IsNullOrEmpty(usernametxt.Text.Trim()))
            {
                errorProvider1.SetError(usernametxt, "Enter Valid Username!!");
            }
            else
            {
                errorProvider1.SetError(usernametxt, string.Empty);
            }

            if (string.IsNullOrEmpty(passTxt.Text.Trim()))
            {
                errorProvider2.SetError(passTxt, "Enter Password!!");
            }
            else
            {
                errorProvider2.SetError(passTxt, string.Empty);
            }
            try
            {   
                dr.Read();
                string user = dr.GetString(0);
                string pass = dr.GetString(1);
                
                if (string.Equals(usernametxt.Text, user) && string.Equals(passTxt.Text, pass))
                {

                    MessageBox.Show("User successfully logged in");
                    Program.username = usernametxt.Text;
                    if (usernametxt.Text == "Loki")
                    {
                        Program.role = "Admin";
                        Dash ds = new Dash();
                        ds.Show();
                        this.Hide();
                    }
                    else
                    {
                        Program.role = "Guest";
                        Dash ds = new Dash();
                        ds.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("invalid username or Password");
                }
                conn.Close();
                
            }
            catch (Exception e2)
            {
                MessageBox.Show("Invalid Username or Password");
                //MessageBox.Show(e2.Message);
                usernametxt.Clear();
                passTxt.Clear();
                conn.Close();

            }
            conn.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register r = new register();
            r.Show();
            this.Hide();
        }
    }
}
