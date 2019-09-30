using Company.BLL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repository
{  

    public interface IEmployeeRepository : IDisposable
    {
        List<EmployeeDTO> GetListEmployees();
        List<EmployeeDTO> GetListEmployeesById(int id);
    }
}
