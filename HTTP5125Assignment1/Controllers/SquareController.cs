using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the sqaure of the integer input by the user
        /// </summary>
        /// <param name="id">The integer given by the user</param>
        /// <returns>id * id</returns>
        /// <example>
        /// GET: localhost:xx/api/Square/2 => 4
        /// </example>
        public int Get(int id)
        {
            int result = id * id;
            
            return result;
        }
    }
}
