using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Company.BLL.Repository;

namespace Company.UnitTest
{
    [TestClass]
    public class UnitTestEmployeeById
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            var repo = new EmployeeRepository();

            //act

            var filtered_data = repo.GetListEmployeesById(1);

            //assert

            Assert.AreEqual(filtered_data.Count, 1);
        }
    }
}
