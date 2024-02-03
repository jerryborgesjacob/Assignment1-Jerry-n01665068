using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Provides cost of hosting based on number of fortnights
        /// </summary>
        /// <param name="id">integer given by user that indicates the Number of Days (of hosting)</param>
        /// <returns>String that gives summary of all costs (Number of fortnights, cost per fortnight, cost, HST and Total cost with HST</returns>
        /// <example>
        /// GET: localhost.xx/api/HostingCost/0 => "1 Fortnights at $5.50/fortnights = $5.5 CAD | HST 13% = $0.72 CAD | Total = $6.22 CAD"
        /// </example>
        public string Get(double id)
        {

            double total;
            double fortnights = Math.Truncate((id / 14) +1);
             
            double cost = 5.50 * fortnights;
            double hst = Math.Round(cost * 0.13, 2);
            total = Math.Round(cost + hst, 2);

            // string output = fortnights + " Fortnights at $5.50/fortnights = $" + cost + " CAD \n" + "HST 13% = $" + hst +" CAD \n" + "Total = $" + total +" CAD";
            string output = fortnights + " Fortnights at $5.50/FN = $" + cost + " CAD | " + "HST 13% = $" + hst + " CAD | " + "Total = $" + total + " CAD";

            return output;
            /*
            NOTES:
                1. I was unable to return or output 3 separate strings.
                2. '\n' did not work in moving the string to the next line.(This line of code has been commented, line 30).
                3. The 'cost' variable omits the last decimal place in the output, if the last decimal is a zero. 
                   Math.Round was used, to no avail. 
                4. The answers were verified with the sample responses given in assignment.   
            */



        }
    }
}
