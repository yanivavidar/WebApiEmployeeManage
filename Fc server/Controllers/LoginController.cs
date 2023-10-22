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
    [EnableCors(origins:"*",headers: "*",methods: "*")]
    public class LoginController : ApiController
    {
        LoginBL bl = new LoginBL();

        // GET: api/Login
        [Route("api/login")]
        public IEnumerable<Users> Get()
        {
            return bl.getAllUsers();
        }

        // GET: api/Login/5
        public Users Get(int id)
        {
            return bl.getUser(id);
        }

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public string Put(int id, Users user)
        {
            bl.UpdateUserActions(id, user);
            return "numofac update";
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
