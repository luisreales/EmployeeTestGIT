using Company.BLL.ModelFactory;
using Company.BLL.ModelInterface;
using Company.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.ModelConcrete
{
    

    public class EmployeeByHour : IEmployee
    {
        private int _id;
        private string _name;
        private string _contractTypeName;
        private int _roleId;
        private string _roleName;
        private string _roleDescription;
        private double _hourlySalary;
        private double _monthlySalary;

        public EmployeeByHour(Employee emp)
        {
            this._id = emp.id;
            this._name = emp.name;
            this._roleName = emp.roleName;
            this._contractTypeName = emp.contractTypeName;
            this._roleId = emp.roleId;
            this._roleDescription = emp.roleDescription;
            this._hourlySalary = emp.hourlySalary;
            this._monthlySalary = emp.monthlySalary;            
        }       

        public int id
        {
            get { return _id; }
            set { this._id = id; }
        }

        public string name
        {
            get { return _name; }
            set { this._name = name; }
        }

        public string contractTypeName
        {
            get { return _contractTypeName; }
            set { this._contractTypeName = contractTypeName; }
        }

        public int roleId
        {
            get { return _roleId; }
            set { this._roleId = roleId; }
        }

        public string roleName
        {
            get { return _roleName; }
            set { this._roleName = roleName; }
        }

        public string roleDescription
        {
            get { return _roleDescription; }
            set { this._roleDescription = roleDescription; }
        }

        public double hourlySalary
        {
            get { return _hourlySalary; }
            set { this._hourlySalary = hourlySalary; }
        }

        public double monthlySalary
        {
            get { return _monthlySalary; }
            set { this._monthlySalary = monthlySalary; }
        }       

        public double anualSalary
        {
            get { return (120 * hourlySalary) * 12; }

        }

    }
}
