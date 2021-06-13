using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awesome_Meal_App_191546_181510
{
    public class ProductClass
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public float ProductPrice { get; set; }
        public Image ProductImage { get; set; }

        public ProductClass()
        {

        }
        public ProductClass(string ProductName, string ProductCategory, float ProductPrice,Image ProductImage,int id)
        {
            this.ProductName = ProductName;
            this.ProductCategory = ProductCategory;
            this.ProductPrice = ProductPrice;
            this.ProductImage = ProductImage;
            this.Id = id;
        }
        public override string ToString()
        {
            return string.Format("{0} ${1} {2}\n", this.ProductName, this.ProductPrice, this.ProductCategory);
        }
    }
}
