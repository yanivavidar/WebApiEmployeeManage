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
    public class EmployeeWithShiftController : ApiController
    {

        EmployeeWithShiftBL bl = new EmployeeWithShiftBL();
        // GET: api/EmployeeWithShift
        public IEnumerable<EmployeeWithShift> Get()
        {
            return bl.getAllEmployeesWithShift();
        }

        // GET: api/EmployeeWithShift/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EmployeeWithShift
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EmployeeWithShift/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmployeeWithShift/5
        public void Delete(int id)
        {
        }
    }
}
