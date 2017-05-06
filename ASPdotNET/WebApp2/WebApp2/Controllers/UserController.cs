using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApp2.Controllers
{
    public class UserController : ApiController
    {
        public async Task<IHttpActionResult> Delete(int id)
        {
            if (id > 10)
                return NotFound();
            return Ok("usunięto");
        }
    }
}
