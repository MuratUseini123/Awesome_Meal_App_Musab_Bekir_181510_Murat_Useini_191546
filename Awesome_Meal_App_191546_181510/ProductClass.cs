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
        public string ProductTitle { get; set; }
        public string ProductInfo { get; set; }
        public float ProductPrice { get; set; }
        public Image ProductImage { get; set; }

        public ProductClass(string ProductTitle, string ProductInfo, float ProductPrice,Image ProductImage,int id)
        {
            this.ProductTitle = ProductTitle;
            this.ProductInfo = ProductInfo;
            this.ProductPrice = ProductPrice;
            this.ProductImage = ProductImage;
            this.Id = id;
        }
        public override string ToString()
        {
            return string.Format("{0}-{1} ${2} {3}\n", this.ProductTitle, this.ProductInfo, this.ProductPrice, this.Id);
        }
    }
}
