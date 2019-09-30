using Company.BLL.Repository;
using Company.DAL.Model;
using Company.DAL.ModelContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeContext repo = new EmployeeContext();
            var list = repo.GetEmployeesContextAPI();
            foreach (Employee o in list)
            {
                Console.WriteLine("id:{0} name:{1} description:{2} roleid {3} rolename {4} hourlySalary{5}", o.id, o.name, o.roleDescription, o.roleId, o.roleName, o.hourlySalary);
            }

            EmployeeRepository emService = new EmployeeRepository();
            emService.GetListEmployees();
            Console.ReadLine();
        }
    }
}
