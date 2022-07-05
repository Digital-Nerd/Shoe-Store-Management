using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.IO;

namespace shoe_store
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            fillBox();
        }

        private void GoBackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dash ds = new Dash();
            ds.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void fillBox()
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name from items";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    string name = dr.GetString("name");
                    ItemName.Items.Add(name);
                }

                conn.Dispose();
            }
            catch (System.InvalidOperationException e2)
            {
                MessageBox.Show(e2.Message);
                conn.Dispose();
            }
            conn.Dispose();
        }

        private void ItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from items where name='"+ItemName.Text+"' ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32("item_no");
                    string category = dr.GetString("category");
                    int price = dr.GetInt32("price");
                    string detail = dr.GetString("detail");
                    
                    ItemNoTxt.Text = id.ToString();
                    CategoryTxt.Text = category;
                    PriceTxt.Text = price.ToString();
                    DetailTxt.Text = detail;

                    byte[] img = (byte[])(dr["image"]);
                    if(img==null)
                    {
                        ImageBox.Image = null;
                    }
                    else
                    {
                        MemoryStream m = new MemoryStream(img);
                        ImageBox.Image = System.Drawing.Image.FromStream(m);
                    }

                }

                conn.Dispose();
            }
            catch (System.InvalidOperationException e2)
            {
                MessageBox.Show(e2.Message);
                conn.Dispose();
            }
            conn.Dispose();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from items where name='" + ItemName.Text + "' ";
            cmd.CommandType = CommandType.Text;
            
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Item Deleted successfully!!");
                ItemNoTxt.Clear();
                DetailTxt.Clear();
                PriceTxt.Clear();
                CategoryTxt.Clear();
                ImageBox.Image = null;
                ItemName.Text = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured!!");
                MessageBox.Show(ex.ToString());
            }
            conn.Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ItemNoTxt.Clear();
            DetailTxt.Clear();
            PriceTxt.Clear();
            CategoryTxt.Clear();
            ImageBox.Image = null;
            ItemName.Text = null;
        }
    }
}
