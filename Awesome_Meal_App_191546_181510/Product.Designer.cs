
namespace Awesome_Meal_App_191546_181510
{
    partial class Product
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
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.lblProdTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // productPicture
            // 
            this.productPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.productPicture.Location = new System.Drawing.Point(0, 0);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(288, 193);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPicture.TabIndex = 0;
            this.productPicture.TabStop = false;
            // 
            // lblProdTitle
            // 
            this.lblProdTitle.AutoSize = true;
            this.lblProdTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdTitle.ForeColor = System.Drawing.Color.White;
            this.lblProdTitle.Location = new System.Drawing.Point(378, 27);
            this.lblProdTitle.Name = "lblProdTitle";
            this.lblProdTitle.Size = new System.Drawing.Size(167, 37);
            this.lblProdTitle.TabIndex = 1;
            this.lblProdTitle.Text = "Product Title";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(380, 73);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 28);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "0.0$";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(385, 125);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(124, 37);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(529, 125);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(124, 37);
            this.btnViewDetails.TabIndex = 4;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProdTitle);
            this.Controls.Add(this.productPicture);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(724, 193);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.Label lblProdTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnViewDetails;
    }
}
