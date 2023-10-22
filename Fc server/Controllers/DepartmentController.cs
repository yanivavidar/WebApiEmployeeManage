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
    public class DepartmentController : ApiController
    {
        DepartmentBL bl = new DepartmentBL();
        // GET: api/Department
        public IEnumerable<Department> Get()
        {
            return bl.getAllDepartments();
        }

        // GET: api/Department/5
        public Department Get(int id)
        {
            return bl.getDepartment(id);
        }

        // POST: api/Department
        public string Post(Department department)
        {
            bl.AddDepartment(department);
            return "department added";
        }

        // PUT: api/Department/5
        public string Put(int id, Department department)
        {
            bl.UpdateDepartment(id, department);
            return "department updated";
        }

        // DELETE: api/Department/5
        public string Delete(int id)
        {
            bl.RemoveDepartment(id);
            return "department removed";
        }
    }
}
