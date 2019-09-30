using Company.DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.ModelContext
{
    public class EmployeeContext : IEmployeeContext
    {
        private List<Employee> listEmployee = new List<Employee>();
        static HttpClient client = new HttpClient();


        public IEnumerable<Employee> GetEmployeesContextAPI()
        {
            Uri path = new Uri("http://masglobaltestapi.azurewebsites.net/api/Employees");
            var list = GetEmployeeAsync(path);
            listEmployee = list.Result;
            return listEmployee;
        }

        static async Task<List<Employee>> GetEmployeeAsync(Uri path)
        {
            List<Employee> employeeList = null;
            var task = await client.GetAsync(path, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            //var task = await client.GetAsync(path);
            var jsonString = await task.Content.ReadAsStringAsync();

            employeeList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);

            return employeeList;
        }
    }
}
