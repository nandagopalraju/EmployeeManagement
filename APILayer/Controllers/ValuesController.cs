using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeServices : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;
        public EmployeeServices(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpGet]
        [Route("get")]
        public ActionResult<List<Employee>> Get()
        {
            return _employeeServices.Get();
        }

    }
}
