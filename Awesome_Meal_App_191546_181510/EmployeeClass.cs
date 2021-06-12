using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awesome_Meal_App_191546_181510
{
    public class EmployeeClass
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmployeeId { get; set; }
        public string LoginPassword{ get; set; }

        public EmployeeClass()
        {

        }
        public EmployeeClass(string Name, string Surname, string EmployeeId, string LoginPassword,int id)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.EmployeeId = EmployeeId;
            this.LoginPassword = LoginPassword;
            this.id = id;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", this.Name, this.Surname, this.EmployeeId);
        }
    }
}
