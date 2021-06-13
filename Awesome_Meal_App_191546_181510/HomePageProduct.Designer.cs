
namespace Awesome_Meal_App_191546_181510
{
    partial class HomePageProduct
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
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.bckLineColor = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHomeProdcat = new System.Windows.Forms.Label();
            this.lblProductHomePage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureProduct
            // 
            this.pictureProduct.Location = new System.Drawing.Point(164, 75);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(322, 296);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduct.TabIndex = 1;
            this.pictureProduct.TabStop = false;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.Location = new System.Drawing.Point(222, 388);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(34, 28);
            this.lblProdPrice.TabIndex = 2;
            this.lblProdPrice.Text = "$0";
            // 
            // bckLineColor
            // 
            this.bckLineColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.bckLineColor.Enabled = false;
            this.bckLineColor.Location = new System.Drawing.Point(53, 115);
            this.bckLineColor.Name = "bckLineColor";
            this.bckLineColor.Size = new System.Drawing.Size(546, 125);
            this.bckLineColor.TabIndex = 4;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(266, 470);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(110, 46);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category:";
            // 
            // lblHomeProdcat
            // 
            this.lblHomeProdcat.AutoSize = true;
            this.lblHomeProdcat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeProdcat.Location = new System.Drawing.Point(261, 430);
            this.lblHomeProdcat.Name = "lblHomeProdcat";
            this.lblHomeProdcat.Size = new System.Drawing.Size(16, 28);
            this.lblHomeProdcat.TabIndex = 9;
            this.lblHomeProdcat.Text = ".";
            // 
            // lblProductHomePage
            // 
            this.lblProductHomePage.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.lblProductHomePage.Location = new System.Drawing.Point(164, 10);
            this.lblProductHomePage.Name = "lblProductHomePage";
            this.lblProductHomePage.Size = new System.Drawing.Size(435, 62);
            this.lblProductHomePage.TabIndex = 10;
            this.lblProductHomePage.Text = "Product Name";
            this.lblProductHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomePageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProductHomePage);
            this.Controls.Add(this.lblHomeProdcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.bckLineColor);
            this.Controls.Add(this.lblProdPrice);
            this.Name = "HomePageProduct";
            this.Size = new System.Drawing.Size(650, 607);
            this.Load += new System.EventHandler(this.HomePageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Panel bckLineColor;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHomeProdcat;
        private System.Windows.Forms.Label lblProductHomePage;
    }
}
