using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public interface IEmployeeServices
    {
        List<Employee> Get();
        //List<Employee> Post();
        //List<Employee> Edit();
        //List<Employee> Delete();
    }
}
