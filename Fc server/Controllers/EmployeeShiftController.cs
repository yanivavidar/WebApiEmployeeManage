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
    public class EmployeeShiftController : ApiController
    {
        // GET: api/EmployeeShift
        EmployeeShiftBL bl = new EmployeeShiftBL();
        public IEnumerable<EmployeeShift> Get()
        {
            return bl.getAllEmployeeShift();
        }

        // GET: api/EmployeeShift/5
        public EmployeeShift Get(int id)
        {
            return bl.getEmployeeShift(id);
        }

        // POST: api/EmployeeShift
        public string Post(EmployeeShift value)
        {
            bl.AddEmployeeShift(value);
            return "adding employee shift";
        }

        // PUT: api/EmployeeShift/5
        public void Put(int id, EmployeeShift value)
        {
        }

        // DELETE: api/EmployeeShift/5
        public string Delete(int id)
        {
            bl.RemoveEmployeeShift(id);
            return "remove employee shift";
        }
    }
}
