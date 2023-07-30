using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine;
using ThalesTest.API.Business;
using ThalesTest.Data.Models;

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
            Assert.That(testEmployee.employee_annual_salary, Is.EqualTo(EXPECTED_SALARY));
        }
    }
}