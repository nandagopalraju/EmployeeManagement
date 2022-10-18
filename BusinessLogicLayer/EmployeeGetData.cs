using BusinessLogicLayer.Services;
using ModelLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EmployeeGetData : IEmployeeServices
    {
        private readonly ApplicationDbContext _context;
        public EmployeeGetData(ApplicationDbContext context)
        {
            _context=context;
        }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
            
        }
    }
}
