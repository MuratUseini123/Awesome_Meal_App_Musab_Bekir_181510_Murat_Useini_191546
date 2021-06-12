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
    public partial class HomePageProduct : UserControl
    {
        public HomePageProduct()
        {
            InitializeComponent();
        }
        #region Properties
        private string _title;
        private string _info;
        private Image _productImage;
        private Color _lineColor;
        private float _productPrice;

        [Category("Home Page Product")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Home Page Product")]
        public float ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; lblProdPrice.Text = string.Format("${0}", value.ToString()); }
        }
        [Category("Home Page Product")]
        public string Info
        {
            get { return _info; }
            set { _info = value; lblInfo.Text = value; }
        }

        [Category("Home Page Product")]
        public Image ProductImage
        {
            get { return _productImage; }
            set { _productImage = value; pictureProduct.Image = value; }
        }

        [Category("Home Page Product")]
        public Color LineColor
        {
            get { return _lineColor; }
            set { _lineColor = value; bckLineColor.BackColor = value; line.BackColor = value; }
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomePageProduct_Load(object sender, EventArgs e)
        {
            
        }
    }
}
