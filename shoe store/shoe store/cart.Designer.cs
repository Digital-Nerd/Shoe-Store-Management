
namespace shoe_store
{
    partial class cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GoBackLink = new System.Windows.Forms.LinkLabel();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.AppExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubTotalLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(36)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.IdTxt);
            this.panel1.Controls.Add(this.UsernameTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GoBackLink);
            this.panel1.Controls.Add(this.LogOutLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 826);
            this.panel1.TabIndex = 0;
            // 
            // IdTxt
            // 
            this.IdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(36)))), ((int)(((byte)(146)))));
            this.IdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTxt.ForeColor = System.Drawing.SystemColors.Menu;
            this.IdTxt.Location = new System.Drawing.Point(33, 132);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(125, 20);
            this.IdTxt.TabIndex = 5;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(36)))), ((int)(((byte)(146)))));
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTxt.ForeColor = System.Drawing.SystemColors.Menu;
            this.UsernameTxt.Location = new System.Drawing.Point(33, 48);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(125, 20);
            this.UsernameTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // GoBackLink
            // 
            this.GoBackLink.AutoSize = true;
            this.GoBackLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBackLink.LinkColor = System.Drawing.Color.Lime;
            this.GoBackLink.Location = new System.Drawing.Point(33, 728);
            this.GoBackLink.Name = "GoBackLink";
            this.GoBackLink.Size = new System.Drawing.Size(83, 28);
            this.GoBackLink.TabIndex = 1;
            this.GoBackLink.TabStop = true;
            this.GoBackLink.Text = "Go Back";
            this.GoBackLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBackLink_LinkClicked);
            // 
            // LogOutLink
            // 
            this.LogOutLink.AutoSize = true;
            this.LogOutLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutLink.LinkColor = System.Drawing.Color.Lime;
            this.LogOutLink.Location = new System.Drawing.Point(33, 774);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(83, 28);
            this.LogOutLink.TabIndex = 0;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "Log Out";
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLink_LinkClicked);
            // 
            // AppExit
            // 
            this.AppExit.BackColor = System.Drawing.Color.Maroon;
            this.AppExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AppExit.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppExit.ForeColor = System.Drawing.Color.White;
            this.AppExit.Location = new System.Drawing.Point(1089, 12);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(50, 43);
            this.AppExit.TabIndex = 6;
            this.AppExit.Text = "X";
            this.AppExit.UseVisualStyleBackColor = false;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(678, 252);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(779, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sub Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(574, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 55);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cart";
            // 
            // SubTotalLbl
            // 
            this.SubTotalLbl.AutoSize = true;
            this.SubTotalLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubTotalLbl.Location = new System.Drawing.Point(874, 484);
            this.SubTotalLbl.Name = "SubTotalLbl";
            this.SubTotalLbl.Size = new System.Drawing.Size(65, 25);
            this.SubTotalLbl.TabIndex = 11;
            this.SubTotalLbl.Text = "label5";
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 826);
            this.Controls.Add(this.SubTotalLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AppExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel GoBackLink;
        private System.Windows.Forms.LinkLabel LogOutLink;
        private System.Windows.Forms.Button AppExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SubTotalLbl;
    }
}