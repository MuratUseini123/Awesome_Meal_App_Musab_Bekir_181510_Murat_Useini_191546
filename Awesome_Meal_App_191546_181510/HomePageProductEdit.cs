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
    public partial class HomePageProductEdit : Form
    {
        public ProductClass newHomePageProd = new ProductClass();
        public string tempString;
        public Image tempImage;
        public HomePageProductEdit()
        {
            InitializeComponent();
        }

        private void HomePageProductEdit_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            var filenames = data as string[];

            if (filenames.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(filenames[0]);
                newHomePageProd.ProductImage = Image.FromFile(filenames[0]);
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnConfirmNewProd_Click(object sender, EventArgs e)
        {
            float temp;
            bool convertionSucc = float.TryParse(txtNewProdPrice.Text,out temp);

            if (convertionSucc)
            {
                newHomePageProd.ProductPrice = temp;
                newHomePageProd.ProductName = txtHomeProdTitle.Text;
                newHomePageProd.ProductCategory = txtNewProdCategory.Text;
                tempString = txtHomeProdTitle.Text;
                
                DialogResult = DialogResult.OK;
            }
            else
            {
                newHomePageProd.ProductPrice = 0;
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
