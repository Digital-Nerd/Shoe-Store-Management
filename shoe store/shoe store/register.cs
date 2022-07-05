using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace shoe_store
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Form1 r = new Form1();
            this.Hide();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //int user_ID;
            Random r = new Random();
            int rint = r.Next(0, 100);
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;          
            //cmd.CommandText = "insert into users values(user_id ="+rint+", name ='"+nameTxt.Text+"', username ='" + usernameTxt.Text + "', password = '" + passwordTxt.Text +"', email ='"+emailTxt.Text +"')";
            cmd.CommandText = " insert into users(user_id, name, username, email, password) values(" +rint+", '"+ nameTxt.Text + "', '" + usernameTxt.Text +"', '" + emailTxt.Text + "', '" + passwordTxt.Text + "')";
            cmd.CommandType = CommandType.Text;
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Details saved successfully!!");
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
                conn.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(" error enter valid details!!");
                conn.Dispose();
            }
            
            
            
        }
    }
}
