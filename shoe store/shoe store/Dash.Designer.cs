
namespace shoe_store
{
    partial class Dash
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
            this.MenuBtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AppExit = new System.Windows.Forms.Button();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.CartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuBtn.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.Location = new System.Drawing.Point(387, 675);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(147, 64);
            this.MenuBtn.TabIndex = 1;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbtn.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(107, 675);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(151, 64);
            this.Addbtn.TabIndex = 2;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(939, 675);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(148, 64);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AppExit
            // 
            this.AppExit.BackColor = System.Drawing.Color.Maroon;
            this.AppExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AppExit.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppExit.ForeColor = System.Drawing.Color.White;
            this.AppExit.Location = new System.Drawing.Point(1111, 12);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(50, 43);
            this.AppExit.TabIndex = 4;
            this.AppExit.Text = "X";
            this.AppExit.UseVisualStyleBackColor = false;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutLink.LinkColor = System.Drawing.Color.Green;
            this.logoutLink.Location = new System.Drawing.Point(39, 785);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(78, 28);
            this.logoutLink.TabIndex = 6;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "LogOut";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shoe_store.Properties.Resources.welcome;
            this.pictureBox1.Location = new System.Drawing.Point(47, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.ForeColor = System.Drawing.Color.DimGray;
            this.IdLbl.Location = new System.Drawing.Point(77, 63);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(57, 20);
            this.IdLbl.TabIndex = 8;
            this.IdLbl.Text = "User ID";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.NameLbl.Location = new System.Drawing.Point(59, 24);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(75, 20);
            this.NameLbl.TabIndex = 9;
            this.NameLbl.Text = "Username";
            // 
            // IdTxt
            // 
            this.IdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTxt.Location = new System.Drawing.Point(147, 60);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(146, 20);
            this.IdTxt.TabIndex = 10;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTxt.Location = new System.Drawing.Point(148, 22);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(146, 20);
            this.UsernameTxt.TabIndex = 11;
            // 
            // CartBtn
            // 
            this.CartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CartBtn.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CartBtn.ForeColor = System.Drawing.Color.White;
            this.CartBtn.Location = new System.Drawing.Point(663, 675);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(147, 64);
            this.CartBtn.TabIndex = 12;
            this.CartBtn.Text = "Cart";
            this.CartBtn.UseVisualStyleBackColor = false;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 846);
            this.Controls.Add(this.CartBtn);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.AppExit);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.MenuBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AppExit;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Button CartBtn;
        //private UserControls.welcome welcome1;
    }
}