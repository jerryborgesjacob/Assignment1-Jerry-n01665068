using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public string Get(double id)
        {
            string result = "The Sin of " + id + " is " + Math.Sin(id) + " | " + 
                "The tan of " + id + " is " + Math.Tan(id) + " | " +
                "The cos of " + id + " is " + Math.Cos(id) + " | " +
                "The Log of " + id + " is " + Math.Log10(Math.Abs(id)) + ".";

            return result;
        }
        
        
    }
}
