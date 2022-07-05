
namespace shoe_store
{
    partial class ItemDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.DetailLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QtyTxt
            // 
            this.QtyTxt.Location = new System.Drawing.Point(493, 298);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.PlaceholderText = "Quantity";
            this.QtyTxt.Size = new System.Drawing.Size(94, 27);
            this.QtyTxt.TabIndex = 20;
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddToCartBtn.Location = new System.Drawing.Point(493, 352);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(107, 42);
            this.AddToCartBtn.TabIndex = 19;
            this.AddToCartBtn.Text = "Add to Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLbl.Location = new System.Drawing.Point(493, 270);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(54, 25);
            this.PriceLbl.TabIndex = 18;
            this.PriceLbl.Text = "Price";
            // 
            // DetailLbl
            // 
            this.DetailLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailLbl.Location = new System.Drawing.Point(493, 160);
            this.DetailLbl.Name = "DetailLbl";
            this.DetailLbl.Size = new System.Drawing.Size(240, 110);
            this.DetailLbl.TabIndex = 17;
            this.DetailLbl.Text = "Detail";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(493, 120);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(69, 20);
            this.CategoryLbl.TabIndex = 16;
            this.CategoryLbl.Text = "Category";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(491, 78);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(68, 37);
            this.TitleLbl.TabIndex = 15;
            this.TitleLbl.Text = "Title";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(89, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(371, 335);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // ItemDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.AddToCartBtn);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.DetailLbl);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.pictureBox);
            this.Name = "ItemDisplay";
            this.Size = new System.Drawing.Size(966, 462);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QtyTxt;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label DetailLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
