using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FactoryProject.Models;
using System.Web.Http.Cors;

namespace FactoryProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        EmployeeBLs bl = new EmployeeBLs();
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return bl.getAllEmployees();
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            return bl.getEmployee(id);
        }

        // POST: api/Employee
        public string Post(Employee employee)
        {
            bl.AddEmployee(employee);
            return "its added";
        }

        // PUT: api/Employee/5
        public string Put(int id, Employee employee)
        {
            bl.UpdateEmployee(id, employee);
            return "updating";
        }

        // DELETE: api/Employee/5
        public string Delete(int id)
        {
            bl.RemoveEmployee(id);
            return "removing";
        }
    }
}
