using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awesome_Meal_App_191546_181510
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }
        #region Properties
        private string _title;
        private float _productPrice;
        private Image _productImage;
        private string _productCategory;
        [Category("Product list item")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblProdTitle.Text = value; }
        }
        [Category("Product list item")]
        public string ProductCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; lblProdCat.Text = value; }
        }

        [Category("Product list item")]
        public float ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; lblPrice.Text = string.Format("{0}$",value); }
        }

        [Category("Product list item")]
        public Image Image
        {
            get { return _productImage; }
            set { _productImage = value; productPicture.Image = value; }
        }
        #endregion

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current order button clicked "+this.Title);
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
