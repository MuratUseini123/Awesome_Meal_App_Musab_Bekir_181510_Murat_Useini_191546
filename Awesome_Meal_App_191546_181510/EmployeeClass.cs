using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awesome_Meal_App_191546_181510
{
    public class EmployeeClass
    {
        public string EmployeeId { get; set; }
        public string LoginPassword{ get; set; }

        public EmployeeClass()
        {

        }
        public EmployeeClass(string EmployeeId, string LoginPassword)
        {
            this.EmployeeId = EmployeeId;
            this.LoginPassword = LoginPassword;
            
        }
        public override string ToString()
        {
            return string.Format("{0}",  this.EmployeeId);
        }
    }
}
