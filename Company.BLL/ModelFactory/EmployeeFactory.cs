using Company.BLL.ModelConcrete;
using Company.BLL.ModelInterface;
using Company.DAL.Model;

namespace Company.BLL.ModelFactory
{
    public static class EmployeeFactory
    {
        public static IEmployee Build(Employee em)
        {

            switch (em.roleId)
            {
                case 1:
                    return new EmployeeByHour(em);
                case 2:
                    return new EmployeeByMonth(em);
                default:

                    return null;
            }

        }
    }

}
