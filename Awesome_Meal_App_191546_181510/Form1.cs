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
    public partial class Form1 : Form
    {
        static private List<ProductClass> products;
        static private EmployeeClass currentLoggedEmploye;
       // private bool isLoginFormActive = false;
        public Product productx = new Product();
        public Form1()
        {
            products = new List<ProductClass>();
            currentLoggedEmploye = null;
            InitializeComponent();
        }

        private void brandPic_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Facebook Link");
        }

        private void btnTwiter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twitter link");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Instagram Link");
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
            
            for (int i = 0; i < 100; i++)
            {
                productx = new Product();
                this.productx.BackColor = System.Drawing.SystemColors.ControlDark;
                this.productx.Image = Image.FromFile(@"C:\Users\inTech_PC\source\repos\Awesome_Meal_App_191546_181510\Awesome_Meal_App_191546_181510\Images\pngaaa.com-2056024.png");
                this.productx.Location = new System.Drawing.Point(3, 3 + (i + 100));
                this.productx.Name = "product1";
                this.productx.ProductPrice = 25.5F;
                this.productx.Size = new System.Drawing.Size(724, 193);
                this.productx.TabIndex = i;
                this.productx.Title = "Doner" + i;
                productList.Controls.Add(productx);

                ProductClass newProduct = new ProductClass("Doner"+i,"wadwad",25.5F,productx.Image,i);
                products.Add(newProduct);


                productx = null;
            }
        }

        /*private void switchMessagePanel(bool isUser)
        {
            if (isUser)
            {
                pnlCustomerMessage.Enabled = true;
                pnlCustomerMessage.Visible = true;
                loggedStaffMemberInfoPnl.Enabled = false;
                loggedStaffMemberInfoPnl.Visible = false;
                pnlEmployee.Enabled = false;
                pnlEmployee.Visible = false;
            }
            else
            {
                pnlCustomerMessage.Enabled = false;
                pnlCustomerMessage.Visible = false;
                loggedStaffMemberInfoPnl.Enabled = true;
                loggedStaffMemberInfoPnl.Visible = true;
                pnlEmployee.Enabled = true;
                pnlEmployee.Visible = true;
            }
        }*/

        private void button3_Click(object sender, EventArgs e)//TODO make sure there is only one instance of login form
        {
            
            verticalLine.Location = new System.Drawing.Point(210, 84+104);

            LoginForm newLoginForm = new LoginForm();
            newLoginForm.ShowDialog();

            /*while (!isLoginFormActive)
            {
                this.Enabled = false;
            }*///TODO if login form is active then main Form is disabled for interaction

            //bool isUser = true;
            if(newLoginForm.DialogResult == DialogResult.OK)
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

                    txtStMemberMessage.Text = currentLoggedEmploye.Name + " " + currentLoggedEmploye.Surname;
                    staffmemberLogOutlbl.Text = currentLoggedEmploye.Name + " " + currentLoggedEmploye.Surname;

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

        private void button4_Click(object sender, EventArgs e)
        {
            verticalLine.Location = new System.Drawing.Point(210, 84+156);
            productList.Visible = false;
            homePageProduct.Visible = false;
            pnlAbout.Visible = true;
           
        }
    }
}
