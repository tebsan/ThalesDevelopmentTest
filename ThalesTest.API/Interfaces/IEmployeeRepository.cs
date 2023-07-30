using Microsoft.AspNetCore.Mvc;
using ThalesTest.API.Models;

namespace ThalesTest.API.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<string> GetAllEmployees();
        Task<string> GetEmployeeById(int id);
    }
}
