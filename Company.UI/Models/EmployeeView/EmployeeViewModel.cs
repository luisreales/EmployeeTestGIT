using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.UI.Models.EmployeeView
{
    public class EmployeeViewModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public string roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public string hourlySalary { get; set; }
        public string monthlySalary { get; set; }

        public string anualSalary { get; set; }
    }
}