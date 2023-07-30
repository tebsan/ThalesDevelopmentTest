using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine;
using ThalesTest.API.Business;
using ThalesTest.API.Models;

namespace ThalesTest.Tests
{
    public class AnnualSalaryCalculationTest
    {

        private Employee testEmployee;
        private const long EXPECTED_SALARY = 12000;

        [SetUp]
        public void Setup()
        {
            testEmployee = new Employee();
            testEmployee.employee_salary = 1000;

        }

        [Test]
        public void Test1()
        {
            testEmployee.employee_annual_salary = EmployeeHelper.CalculateAnualSalary(testEmployee.employee_salary);
            Assert.AreEqual(EXPECTED_SALARY, testEmployee.employee_annual_salary);
        }
    }
}