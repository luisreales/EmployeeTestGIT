using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.BLL.ModelDTO;
using Company.BLL.ModelFactory;
using Company.DAL.ModelContext;
using Company.DAL.Model;

namespace Company.BLL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        EmployeeContext context;

        public EmployeeRepository()
        {
            this.context = new EmployeeContext();
        }        

        public List<EmployeeDTO> GetListEmployees()
        {
            List<EmployeeDTO> listEmployees = new List<EmployeeDTO>();            
            EmployeeDTO dtoEmployee;

            var lstEmployees = context.GetEmployeesContextAPI();

            foreach (var employee_item in lstEmployees)
            {

                dtoEmployee = GetEmployeeFactory(employee_item);
                listEmployees.Add(dtoEmployee);

            }

            return listEmployees;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        private EmployeeDTO GetEmployeeFactory(Employee emp)
        {

            try
            {
                EmployeeDTO empDTO = new EmployeeDTO();
                object varDataEmployee = EmployeeFactory.Build(emp);

                if (varDataEmployee != null)
                {

                    empDTO.id = (int)varDataEmployee.GetType().GetProperty("id").GetValue(varDataEmployee, null);
                    empDTO.name = varDataEmployee.GetType().GetProperty("name").GetValue(varDataEmployee, null) as string;
                    empDTO.contractTypeName = varDataEmployee.GetType().GetProperty("contractTypeName").GetValue(varDataEmployee, null) as string;
                    empDTO.roleId = (int)varDataEmployee.GetType().GetProperty("roleId").GetValue(varDataEmployee, null);
                    empDTO.roleName = varDataEmployee.GetType().GetProperty("roleName").GetValue(varDataEmployee, null) as string;
                    empDTO.hourlySalary = (double)varDataEmployee.GetType().GetProperty("hourlySalary").GetValue(varDataEmployee, null);
                    empDTO.monthlySalary = (double)varDataEmployee.GetType().GetProperty("monthlySalary").GetValue(varDataEmployee, null);
                    empDTO.anualSalary = (double)varDataEmployee.GetType().GetProperty("anualSalary").GetValue(varDataEmployee, null);
                }

                return empDTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<EmployeeDTO> GetListEmployeesById(int id)
        {
            List<EmployeeDTO> listEmployees = new List<EmployeeDTO>();
            EmployeeDTO dtoEmployee;

            var lstEmployees = context.GetEmployeesContextAPI();

            foreach (var employee_item in lstEmployees)
            {

                dtoEmployee = GetEmployeeFactory(employee_item);
                listEmployees.Add(dtoEmployee);

            }

            if(id != 0)
            {
                listEmployees = listEmployees.Where(itemEmployee => itemEmployee.id == id).ToList();
            }

            return listEmployees;
        }
    }
}
