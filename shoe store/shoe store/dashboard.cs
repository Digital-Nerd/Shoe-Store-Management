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
    public partial class dashboard : Form
    {
        public dashboard(int id)
        {
            InitializeComponent();
            UsernameTxt.Text = Program.username;
            IdTxt.Text = id.ToString();
            fillBox();
        }

        public dashboard(string role)
        {
            InitializeComponent();
            if (role=="Guest")
            {                
                label1.Hide();
                label2.Hide();
                IdTxt.Hide();
                UsernameTxt.Hide();
                fillBox();
                GoBack.Hide();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fmObj = new Form1();
            this.Hide();
            fmObj.Show();

        }

        private void close_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select * from items ";   
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //SportsShoe[] ss = new SportsShoe[20];
            ItemDisplay[] Id = new ItemDisplay[20];
                                    
            try
            {

                for (int i = 0; i < Id.Length; ++i)
                {
                    while (dr.Read())
                    {                        
                        string name = dr.GetString("name");
                        string category = dr.GetString("category");
                        string detail = dr.GetString("detail");
                        int price = dr.GetInt32("price");

                        byte[] img = (byte[])(dr["image"]);
                    

                            Id[i] = new ItemDisplay();
                            Id[i].Title = name;
                            Id[i].Group = category;
                            Id[i].Description = detail;
                            Id[i].Price = price;
                            
                                                        
                            if (img == null)
                            {
                                Id[i].Photo = null;
                            }
                            else
                            {
                                MemoryStream m = new MemoryStream(img);
                                Id[i].Photo = System.Drawing.Image.FromStream(m);
                            }


                            if (flowLayoutPanel.Controls.Count < 0) 
                            {
                                flowLayoutPanel.Controls.Clear(); 
                            }

                            flowLayoutPanel.Controls.Add(Id[i]);
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

        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dash ds = new Dash();
            this.Hide();
            ds.Show();
        }
        
    }
}
