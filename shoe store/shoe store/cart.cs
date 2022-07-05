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
    public partial class cart : Form
    {
        public cart()
        {
            InitializeComponent();
            fillbox();
            total();
            UsernameTxt.Text = Program.username;
            IdTxt.Text = Program.id;
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dash d = new Dash();
            this.Hide();
            d.Show();
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        void fillbox()
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();            
            cmd.Connection = conn;
            cmd.CommandText = "select Item_Name, category, price, QTY, Total from cart where username= '" + Program.username + "' ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                da.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                da.Fill(dbdataset);
                BindingSource bs = new BindingSource();
                bs.DataSource = dbdataset;
                dataGridView1.DataSource = bs;
                da.Update(dbdataset);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        void total()
        {            
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sum(total) from cart where username= '" + Program.username + "' ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            try
            {
                while(dr.Read())
                {
                    SubTotalLbl.Text = dr.GetValue(0).ToString();
                }                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
