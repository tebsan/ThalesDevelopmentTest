﻿
using Newtonsoft.Json;
using RestSharp;
using CommonComponents.Interfaces;
using ThalesTest.Data.Models;
using ThalesTest.API.Business;

namespace ThalesTest.Data.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<string> GetAllEmployees()
        {
            using (var client = new RestClient())
            {
                var request = new RestRequest($"http://dummy.restapiexample.com/api/v1/employees", method: Method.Get);
                RestResponse response = await client.ExecuteAsync<IEnumerable<Employee>>(request);

                ApiResponse responseData = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                IEnumerable<Employee> employees = null;
                if(responseData.data != null)
                {
                    employees = responseData.data;
                    foreach (Employee employee in employees)
                    {
                        employee.employee_annual_salary = EmployeeHelper.CalculateAnualSalary(employee.employee_salary);
                    }
                }
              
                return JsonConvert.SerializeObject(employees);
            }
        }

        public async Task<string> GetEmployeeById(int id)
        {
            using (var client = new RestClient())
            {
                var request = new RestRequest($"http://dummy.restapiexample.com/api/v1/employee/{id}", method: Method.Get);
                RestResponse response = await client.ExecuteAsync<Employee>(request);
                ApiResponse employeeData = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                Employee employee = null;
                if(employeeData.data != null)
                {
                    employee = employeeData.data.First();
                    employee.employee_annual_salary = EmployeeHelper.CalculateAnualSalary(employee.employee_salary);
                }
                
                return JsonConvert.SerializeObject(employee); 
            }
        }
    }
}
