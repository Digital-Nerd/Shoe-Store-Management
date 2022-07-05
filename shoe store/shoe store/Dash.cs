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
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
            fillbox();
            if (Program.role == "Guest")
            {
                MenuBtn.Show(); // view menu for a guest/ customer
                Addbtn.Hide();
                DeleteBtn.Hide();

            }
            else // (Program.role == "Admin")
            {                
                MenuBtn.Show();     //showing admin functionalities to add or deltel an item
                Addbtn.Show();
                DeleteBtn.Show();

            }
        }
               
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            dashboard ds = new dashboard(int.Parse(IdTxt.Text));
            ds.Show();
            this.Hide();
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Add ad = new Add();
            ad.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.Hide();
        }

        void fillbox()
        {
            String oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select user_id from users where username= '" + Program.username + "' ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
           
            try
            {                
                    while (dr.Read())
                    {
                        String name = Program.username;
                        String id = dr.GetInt32("user_id").ToString();

                        UsernameTxt.Text = Program.username;
                        Program.id = id;
                        IdTxt.Text = id;
                    }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            cart c = new cart();
            c.Show();
            this.Hide();
        }
    }
}
