using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Awesome_Meal_App_191546_181510;

namespace Awesome_Meal_App_191546_181510
{
    public partial class LoginForm : Form
    {
        public EmployeeClass loggedEmployee = null;
        public List<EmployeeClass> employees;
        public string LoggedEmployeeName;
        public LoginForm()
        {
            this.employees = new List<EmployeeClass>();
            employees.Add(new EmployeeClass("Murat","Useini","191546","login191546",0));
            employees.Add(new EmployeeClass("Musab", "Bekir", "181510", "login181510", 1));
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.LoggedEmployeeName = txtEmployeeId.Text;
            bool isFound = false;

            if (
            employees.Find(employee => employee.EmployeeId.Equals(txtEmployeeId.Text)) != null && 
            employees.Find(employee=>employee.LoginPassword.Equals(txtEmployeePass.Text))!=null
            ){
                isFound = true;
            }

            if (isFound)
            {
                loggedEmployee = new EmployeeClass();
                loggedEmployee = employees.Find(employee => employee.EmployeeId.Equals(txtEmployeeId.Text));
                DialogResult = DialogResult.OK;
                this.Close();
            }else
            {
                loggedEmployee = null;
                DialogResult = DialogResult.No;
                MessageBox.Show(string.Format("Employe with employeeID [{0}] is not registered!!!", LoggedEmployeeName));
                this.Close();
            }
           
        }
        private void txtEmployeeId_Validating_1(object sender, CancelEventArgs e)
        {
            
                if (txtEmployeeId.Text == "")
                {
                    errorProvider1.SetError(txtEmployeeId, "Empty input");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtEmployeeId, "");
                    e.Cancel = false;
                }
            
        }
        private void txtEmployeePass_Validating(object sender, CancelEventArgs e)
        {
            
                if (txtEmployeePass.Text == "")
                {
                    errorProvider2.SetError(txtEmployeePass, "Empty input");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider2.SetError(txtEmployeePass, "");
                    e.Cancel = false;
                } 
        }

        private void txtEmployeeId_Enter(object sender, EventArgs e)
        {
            txtEmployeeId.Clear();
        }

        private void txtEmployeePass_Enter(object sender, EventArgs e)
        {
            txtEmployeePass.Clear();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (btnLogin.CanFocus)
            {
                btnLogin.Focus();
            }
        }

        private void chckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckShowPass.Checked)
            {
                txtEmployeePass.PasswordChar = (char)0;
            }else
            {
                txtEmployeePass.PasswordChar = '*';
            }
        }
    }
}
