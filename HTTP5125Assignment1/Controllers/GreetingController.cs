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
        /// <summary>
        /// Returns the string "Hello World!"
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns the string "Greetings to {id} people!", where id is the interger given by user.
        /// </summary>
        /// <param name="id">integer given by the user</param>
        /// <returns>"Greetings to {id} people!"</returns>
        /// <example>
        /// POST: localhost.xx/api/Greeting/3 => "Greetings to 3 people!"
        /// </example>
        public string Post(int id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }
    }
}
