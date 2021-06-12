using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Awesome_Meal_App_191546_181510
{
    
    public partial class RegisterForm : Form

    {
        
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int employeeId = 0;            

            if (textBoxRestaurantPassword.Text != "finkiVPproject")
            {
                MessageBox.Show("Restaurant password is invalid!");
            }
            else if (String.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter your Full Name!");
            }
            else if (String.IsNullOrEmpty(textBoxPasswordReg.Text))
            {
                MessageBox.Show("Please enter a registration password!");
            }
            else if (textBoxPasswordReg.Text != textBoxConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            else
            {
                string fileName = "LoginDatabase.mdf";
                string path = Path.GetFullPath(fileName);

                SqlConnection staffCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+";Integrated Security=True");
                SqlCommand registerStaff = new SqlCommand(@"INSERT INTO [dbo].[login] ([username],[password],[name],[surname]) VALUES ('" + textBoxUsername.Text + "', '" + textBoxPasswordReg.Text + "', '" + textBoxName.Text + "', '" + textBoxSurname.Text + "'  ) ", staffCon);
                staffCon.Open();
                registerStaff.ExecuteNonQuery();
                staffCon.Close();
                MessageBox.Show("Register Successful. You can log in now!");
                
                this.Close();
            }
            employeeId++;
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
