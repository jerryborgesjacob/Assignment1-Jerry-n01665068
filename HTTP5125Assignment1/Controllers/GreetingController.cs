using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello World!";
        }

        public string Post(int id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }
    }
}
