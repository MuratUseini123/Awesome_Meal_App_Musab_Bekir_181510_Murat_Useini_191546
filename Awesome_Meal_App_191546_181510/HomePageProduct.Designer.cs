
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Panel();
            this.bckLineColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblTitle.Location = new System.Drawing.Point(219, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Title";
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
            this.lblProdPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.Location = new System.Drawing.Point(473, 404);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(47, 37);
            this.lblProdPrice.TabIndex = 2;
            this.lblProdPrice.Text = "$0";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(128, 388);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(322, 82);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem " +
    "Ipsum has been the industry\'s standard dummy text ever since the 1500s,";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(269, 473);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(110, 46);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line.Location = new System.Drawing.Point(177, 455);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(296, 5);
            this.line.TabIndex = 7;
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
            // HomePageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.line);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.bckLineColor);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblTitle);
            this.Name = "HomePageProduct";
            this.Size = new System.Drawing.Size(650, 607);
            this.Load += new System.EventHandler(this.HomePageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel bckLineColor;
    }
}
