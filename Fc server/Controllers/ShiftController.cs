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
    public class ShiftController : ApiController
    {
        ShiftBL bl = new ShiftBL();
        // GET: api/Shift
        public IEnumerable<Shift> Get()
        {
            return bl.getAllShifts();
        }

        // GET: api/Shift/5
        public Shift Get(int id)
        {
            return bl.getShift(id);
        }

        // POST: api/Shift
        public string Post(Shift value)
        {
            bl.AddShift(value);
            return "shift added";
        }

        // PUT: api/Shift/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shift/5
        public void Delete(int id)
        {
        }
    }
}
