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
        /// <summary>
        /// Returns 10 more than the integer input by the user
        /// </summary>
        /// <param name="id">The integer given by the user</param>
        /// <returns>id + 10</returns>
        /// <example>
        ///GET: localhost:xx/api/AddTen/21 => 31
        ///</example>
        public int Get(int id)
        {
            int Result = id + 10;

            return Result;
        }
    }
}
