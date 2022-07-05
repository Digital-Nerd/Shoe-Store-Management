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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            fillBox();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dash ds = new Dash();
            ds.Show();
            this.Hide();
        }

        void fillBox()
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from category";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    Category.Items.Add(name);
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

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                string loc = ofd.FileName.ToString();
                FilePath.Text = loc;
                pictureBox1.ImageLocation = loc;
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            byte[] imgBt;
            FileStream f = new FileStream(FilePath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(f);
            imgBt = r.ReadBytes((int)f.Length);


            string oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "insert into users values(user_id ="+rint+", name ='"+nameTxt.Text+"', username ='" + usernameTxt.Text + "', password = '" + passwordTxt.Text +"', email ='"+emailTxt.Text +"')";
            cmd.CommandText = " insert into items(name, detail, price, category, image) values('" + PnameTxt.Text+ "', '" + DetailTxt.Text +"', '" + PriceTxt.Text + "', '" + Category.Text + "', :img1)";
            cmd.CommandType = CommandType.Text;
            try
            {
                             
                cmd.Parameters.Add(new OracleParameter("img1", imgBt));
                OracleDataReader dr = cmd.ExecuteReader();
               // dr = cmd.ExecuteReader();
                MessageBox.Show("Item Saved");
                PnameTxt.Clear();
                DetailTxt.Clear();
                PriceTxt.Clear();
                pictureBox1.Image = null;
                Category.Text = null;
                FilePath.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error!! ");
                MessageBox.Show(ex.ToString());
                conn.Dispose();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            PnameTxt.Clear();
            DetailTxt.Clear();
            PriceTxt.Clear();
            pictureBox1.Image = null;
            FilePath.Clear();
            Category.Text = null;
        }

        private void PriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char c = e.KeyChar;
            if(!char.IsDigit(c) && c!=8 && c!=46)
            {
                e.Handled = true;
            }
        }
    }
}
