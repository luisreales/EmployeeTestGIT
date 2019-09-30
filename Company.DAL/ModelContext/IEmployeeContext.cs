using Company.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.DAL.ModelContext
{
    interface IEmployeeContext
    {
        IEnumerable<Employee> GetEmployeesContextAPI();
    }
}
