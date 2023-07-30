using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThalesTest.API.Interfaces;

namespace ThalesTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {        
        private IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllEmployees()
        {
            return Content(await _repository.GetAllEmployees(), "application/json");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetEmployeeById(int id)
        {
            return Content(await _repository.GetEmployeeById(id), "application/json");
        }
    }
}
