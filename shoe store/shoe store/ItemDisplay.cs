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
    public partial class ItemDisplay : UserControl
    {
        public ItemDisplay()
        {
            InitializeComponent();
            if (Program.username == "Guest")
            {
                AddToCartBtn.Hide();
                QtyTxt.Hide();
            }
        }


        #region Properties

        private string name;
        private string _category;
        private string desc;
        private int cost;        
        private Image _photo;
        

        [Category("Custom Props")]
        public string Title
        {
            get { return name; }
            set { name = value; TitleLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string Group
        {
            get { return _category; }
            set { _category = value; CategoryLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return desc; }
            set { desc = value; DetailLbl.Text = value; }
        }

        [Category("Custom Props")]
        public int Price
        {
            get { return cost; }
            set { cost = value; PriceLbl.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; pictureBox.Image = value; }
        }



        #endregion

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            
            int totalVal = int.Parse(PriceLbl.Text) * int.Parse(QtyTxt.Text);    // calculating total amount of the specific product
            String oradb = "Data Source=localhost;User Id=DBMS;Password=dbms;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into cart values('" + Program.username + "', '" + TitleLbl.Text + "', '" + CategoryLbl.Text + "', " + int.Parse(PriceLbl.Text) + ", " + int.Parse(QtyTxt.Text) +", "+ totalVal + " )";
            cmd.CommandType = CommandType.Text;

            try
            {
                if(QtyTxt.Text==" " || QtyTxt.Text==null || QtyTxt.Text.Length==0)
                {
                    MessageBox.Show("Please Enter the Quantity");
                    QtyTxt.Focus();
                }

                OracleDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Added to cart SUCCESSFULLY !!");
                
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
