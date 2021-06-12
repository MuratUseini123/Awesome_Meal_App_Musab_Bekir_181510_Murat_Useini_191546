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
using Awesome_Meal_App_191546_181510;
using System.IO;

namespace Awesome_Meal_App_191546_181510
{
    public partial class LoginForm : Form
    {
        //-----------------Murat----------------------------------//
        public EmployeeClass loggedEmployee = null;
        public List<EmployeeClass> employees;
        
        public LoginForm()
        {
            this.employees = new List<EmployeeClass>();
            employees.Add(new EmployeeClass("191546","login191546"));
            employees.Add(new EmployeeClass("181510", "login181510"));
            InitializeComponent();
        }
        //-----------------Murat----------------------------------//
        bool isCanceled = false;

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            isCanceled = true;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileName = "LoginDatabase.mdf";
            string path = Path.GetFullPath(fileName);

            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "+path+"; Integrated Security = True");
            

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + txtUsername.Text + "' and password='" + txtEmployeePassword.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                
                DialogResult = DialogResult.OK;
                loggedEmployee = new EmployeeClass();
                loggedEmployee.EmployeeId = txtUsername.Text;
                loggedEmployee.LoginPassword = txtEmployeePassword.Text;
            }
            else
            {
                DialogResult = DialogResult.Abort;
                MessageBox.Show("Please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void txtEmployeeId_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtEmployeeId_Validating_1(object sender, CancelEventArgs e)
        {
            
                if (txtUsername.Text == "")
                {
                    errorProvider1.SetError(txtUsername, "Empty id input");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtUsername, "");
                    e.Cancel = false;
                }
            
        }

        private void txtEmployeePass_Validating(object sender, CancelEventArgs e)
        {
            
                if (txtEmployeePassword.Text == "")
                {
                    errorProvider2.SetError(txtEmployeePassword, "Empty password input");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider2.SetError(txtEmployeePassword, "");
                    e.Cancel = false;
                }
            
        }

        private void txtEmployeeId_Enter(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtEmployeePass_Enter(object sender, EventArgs e)
        {
            txtEmployeePassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm newRegForm = new RegisterForm();
            newRegForm.Show();
        }

        private void chckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckShowPass.Checked)
            {
                txtEmployeePassword.PasswordChar = (char)0;
            }else
            {
                txtEmployeePassword.PasswordChar = '*';
            }
        }
    }
}
