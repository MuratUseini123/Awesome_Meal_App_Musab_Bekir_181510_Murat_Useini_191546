using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awesome_Meal_App_191546_181510
{
    public partial class Form1 : Form
    {
        private List<ProductClass> products;
        static private EmployeeClass currentLoggedEmploye;

        public Product productx = new Product();
        public Form1()
        {
            products = new List<ProductClass>();
            currentLoggedEmploye = null;
            InitializeComponent();
            
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/FINKI.ukim.mk/");
        }

        private void btnTwiter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/finkiedu?lang=en");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.google.com/search?q=Finki+instagram&sxsrf=ALeKk00fx5p2yzvT5h8dCXUc1oBKQjpDCA%3A1623590593055&source=hp&ei=wQbGYNhCnI2Fsg-XtYfYCw&iflsig=AINFCbYAAAAAYMYU0eitVtiVP6fasKrWNek2POhLTY3f&oq=Finki+instagram&gs_lcp=Cgdnd3Mtd2l6EAMyBAgjECc6CgguEMcBEK8BEEM6BAgAEEM6AggAOgcIABCHAhAUOg0ILhCHAhDHARCvARAUOgUIABCRAjoECAAQCjoECC4QCjoICAAQFhAKEB46BggAEBYQHjoFCCEQoAE6BwghEAoQoAE6BwgjELACECdQ3ghYrj9gqUJoCXAAeACAAaQBiAGNFZIBBDcuMTeYAQCgAQGqAQdnd3Mtd2l6&sclient=gws-wiz&ved=0ahUKEwiYp7qk2pTxAhWcRkEAHZfaAbsQ4dUDCAc&uact=5");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productList.Visible = false;
            homePageProduct.Visible = true;
            pnlAbout.Visible = false;
            verticalLine.Location = new System.Drawing.Point(210,84);
        }

        private void btnProdPanelActivate_Click(object sender, EventArgs e)
        {
            productList.Visible = true;
            homePageProduct.Visible = false;
            pnlAbout.Visible = false;
            verticalLine.Location = new System.Drawing.Point(210, 84+52);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initProducts();
            homePageProduct.Category = "Hamburger";
           
            productList.Visible = false;
            homePageProduct.Visible = true;
            pnlAbout.Visible = false;

            pnlCustomerMessage.Visible = true;
            pnlCustomerMessage.Enabled = true;

            txtStMemberMessage.Enabled = false;
            txtStMemberMessage.Visible = false;
           
            loggedStaffMemberInfoPnl.Visible = false;
            loggedStaffMemberInfoPnl.Enabled = false;

            staffmemberLogOutlbl.Enabled = false;
            staffmemberLogOutlbl.Visible = false;

            initProductList();
        }


        private void initProductList()
        {
            int index = 0;
            foreach (ProductClass product in products)
            {
                productx = new Product();
                this.productx.BackColor = System.Drawing.SystemColors.ControlDark;

                this.productx.Location = new System.Drawing.Point(3, 3 + (index + 100));
                this.productx.PName = product.ProductName;
                this.productx.ProductPrice = product.ProductPrice;
                this.productx.Size = new System.Drawing.Size(724, 193);
                this.productx.TabIndex = index;
                this.productx.ProductCategory = product.ProductCategory;

                productList.Controls.Add(productx);

                productx = null;
                index = index + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)//TODO make sure there is only one instance of login form
        {
            
            verticalLine.Location = new System.Drawing.Point(210, 84+104);

            if (!pnlEmployee.Visible)
            {
                LoginForm newLoginForm = new LoginForm();
                newLoginForm.ShowDialog();

                if (newLoginForm.DialogResult == DialogResult.OK)
                {

                    currentLoggedEmploye = newLoginForm.loggedEmployee;

                    pnlCustomerMessage.Enabled = false;
                    pnlCustomerMessage.Visible = false;
                    loggedStaffMemberInfoPnl.Enabled = true;
                    loggedStaffMemberInfoPnl.Visible = true;
                    pnlEmployee.Enabled = true;
                    pnlEmployee.Visible = true;

                    txtStMemberMessage.Enabled = true;
                    txtStMemberMessage.Visible = true;

                    txtStMemberMessage.Text = currentLoggedEmploye.EmployeeId;
                    staffmemberLogOutlbl.Text = currentLoggedEmploye.EmployeeId;

                    btnHomePageProdEdit.Enabled = true;
                    btnHomePageProdEdit.Visible = true;

                    btnProdLstEdit.Enabled = true;
                    btnProdLstEdit.Visible = true;

                    btnLogOut.Enabled = true;
                    btnLogOut.Visible = true;

                    staffmemberLogOutlbl.Enabled = true;
                    staffmemberLogOutlbl.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("You are allready logged in as username: "+currentLoggedEmploye.EmployeeId);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verticalLine.Location = new System.Drawing.Point(210, 84+156);
            productList.Visible = false;
            homePageProduct.Visible = false;
            pnlAbout.Visible = true;
        }

        private void btnProdLstEdit_Click(object sender, EventArgs e)
        {
            ProductControlForm newProdCForm = new ProductControlForm();
            newProdCForm.Show();
            if(newProdCForm.DialogResult == DialogResult.OK)
            {
                
                productList.Controls.Clear();
                /*productList.Dispose();

                productList = new FlowLayoutPanel();

                this.productList.AutoScroll = true;
                this.productList.Controls.Add(this.pnlAbout);
                this.productList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
                this.productList.Location = new System.Drawing.Point(0, 172);
                this.productList.Name = "productList";
                this.productList.Size = new System.Drawing.Size(772, 596);
                this.productList.TabIndex = 8;
                this.productList.WrapContents = false;*/

                initProducts();
                initProductList();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            pnlCustomerMessage.Enabled = true;
            pnlCustomerMessage.Visible = true;
            loggedStaffMemberInfoPnl.Enabled = false;
            loggedStaffMemberInfoPnl.Visible = false;
            pnlEmployee.Enabled = false;
            pnlEmployee.Visible = false;

            txtStMemberMessage.Enabled = false;
            txtStMemberMessage.Visible = false;

            txtStMemberMessage.Text = "";
            staffmemberLogOutlbl.Text = "";

            currentLoggedEmploye = null; 

            btnHomePageProdEdit.Enabled = false;
            btnHomePageProdEdit.Visible = false;

            btnProdLstEdit.Enabled = false;
            btnProdLstEdit.Visible = false;

            btnLogOut.Enabled = false;
            btnLogOut.Visible = false;

            staffmemberLogOutlbl.Enabled = true;
            staffmemberLogOutlbl.Visible = true;
        }

        private void btnHomePageProdEdit_Click(object sender, EventArgs e)
        {
            HomePageProductEdit newForm = new HomePageProductEdit();
            newForm.ShowDialog();
            if(newForm.DialogResult == DialogResult.OK)
            {
                homePageProduct.Category = newForm.newHomePageProd.ProductCategory;
                homePageProduct.ProductPrice = newForm.newHomePageProd.ProductPrice;
                homePageProduct.Home_Product_Name = newForm.newHomePageProd.ProductName;
                homePageProduct.ProductImage = newForm.newHomePageProd.ProductImage;
            }
        }
        private void initProducts()
        {
            string fileName = "FoodDatabase.mdf";
            string path = Path.GetFullPath(fileName);

            SqlConnection sqlProductsConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");

            sqlProductsConnection.Open();

            SqlDataAdapter sqlProductAdapter = new SqlDataAdapter("SELECT * FROM Food",sqlProductsConnection);

            DataTable dtTable = new DataTable();

            sqlProductAdapter.Fill(dtTable);

            foreach(DataRow dtRow in dtTable.Rows)
            {
                int tempID;
                bool tempB = int.TryParse(dtRow["Id"].ToString(), out tempID);

                float tempPrice;
                bool tempBF = float.TryParse(dtRow["Price"].ToString(), out tempPrice);
                
                products.Add(new ProductClass()
                {
                    Id = tempID,
                    ProductPrice = tempPrice,
                    ProductCategory = dtRow["FoodCategoryName"].ToString(),
                    ProductImage = null,
                    ProductName = dtRow["FoodName"].ToString()
                }) ;
            }
        }
    }
}
