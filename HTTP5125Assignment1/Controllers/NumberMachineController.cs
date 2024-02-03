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
        /// <summary>
        /// Applies 4 mathematical functions to input given by user
        /// </summary>
        /// <param name="id">integer given by the user</param>
        /// <returns>Returns a string that includes sin, tan, cos and Log value of {id}</returns>
        /// <example>
        /// GET: localhost.xx/api/NumberMachine/10 => "The Sin of 10 is -0.54402111088937 | The tan of 10 is 0.648360827459087 | The cos of 10 is -0.839071529076452 | The Log of 10 is 1"
        /// </example>
        public string Get(double id)
        {
            string result = "The Sin of " + id + " is " + Math.Sin(id) + " | " + 
                "The tan of " + id + " is " + Math.Tan(id) + " | " +
                "The cos of " + id + " is " + Math.Cos(id) + " | " +
                "The Log of " + id + " is " + Math.Log10(Math.Abs(id));

            return result;

            /* 
            Notes:
              
             1. Using Math.Log10 (or) Math.Log on negative numbers led to the result being an imaginary number.
                Imaginary numbers are displayed as 'Nan' in the output.
                Hence, I used Math.Abs to convert the negative number into positive, hence preventing the output from being an imaginary number.

             2. I was unable to return multiple strings, and was unable to move the output to different lines using "\n".
                Hence, I used the pipe symbol to differentiate the answers.(create space between the sentences) 

            */


        }
        
        
    }
}
