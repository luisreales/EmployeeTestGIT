using Company.BLL.ModelDTO;
using Company.BLL.Repository;
using Company.DAL.ModelContext;
using Company.UI.Models.EmployeeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Company.UI.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        List<EmployeeViewModel> lstEmployeeVM;

        EmployeeRepository repo = new EmployeeRepository();
        public IEnumerable<EmployeeViewModel> Get()
        {           
            var listEmploye = repo.GetListEmployees();
            return this.GetListViewModelEmployee(listEmploye);            
        }

        // GET: api/Employee/5
        public IEnumerable<EmployeeViewModel> Get(int id)
        {           
            var listEmploye = repo.GetListEmployeesById(id);
            return this.GetListViewModelEmployee(listEmploye);
        }        

        private List<EmployeeViewModel> GetListViewModelEmployee(List<EmployeeDTO> listEmploye)
        {
            EmployeeViewModel objEmployeeVM;
            lstEmployeeVM = new List<EmployeeViewModel>();

            foreach (var itemEmployee in listEmploye)
            {
                objEmployeeVM = new EmployeeViewModel();
                objEmployeeVM.id = itemEmployee.id.ToString();
                objEmployeeVM.name = (itemEmployee.name == null) ? "" : itemEmployee.name;
                objEmployeeVM.contractTypeName = (itemEmployee.contractTypeName == null) ? " " : itemEmployee.contractTypeName;
                objEmployeeVM.roleId = itemEmployee.roleId.ToString();
                objEmployeeVM.roleDescription = (itemEmployee.roleDescription == null) ? " " : itemEmployee.roleDescription;
                objEmployeeVM.roleName = (itemEmployee.roleName == null) ? " " : itemEmployee.roleName;
                objEmployeeVM.hourlySalary = itemEmployee.hourlySalary.ToString("C");
                objEmployeeVM.monthlySalary = itemEmployee.monthlySalary.ToString("C");
                objEmployeeVM.anualSalary = itemEmployee.anualSalary.ToString("C");
                lstEmployeeVM.Add(objEmployeeVM);
            }

            return lstEmployeeVM;
        }
    }
}
