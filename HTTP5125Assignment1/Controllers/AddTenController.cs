using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            int Result = id + 10;

            return Result;
        }
    }
}
