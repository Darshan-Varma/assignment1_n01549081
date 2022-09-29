using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1_n01549081.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculating Fortnight, HST% and total amount for web hosting and maintenance
        /// </summary>
        /// <param name="id">Number of days elapsed since beginning</param>
        /// <returns>
        /// Fortnight in which the day lies and the 13% HST and total cost.
        /// </returns>
        /// <example>
        /// GET api/HostingCost/0 -> “1 fortnights at $5.50/FN = $5.50 CAD”,“HST 13% = $0.72 CAD”,“Total = $6.22 CAD”
        /// GET api/HostingCost/14 -> “2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”
        /// GET api/HostingCost/28 -> “3 fortnights at $5.50/FN = $16.50 CAD”,“HST 13% = $2.14 CAD”,“Total = $18.64 CAD
        /// </example>
        /// GET /api/HostingCost/{id}
        public IEnumerable<string> Get(int id)
        {
            int FN = (id / 14) + 1;
            double HST = FN * 5.50  * 0.13;
            double total = (FN * 5.5) + HST;
            return new string[] { FN + " fortnights at $5.50/FN = $ " + ( 5.50 * FN ) + " CAD", "HST 13% = $" + HST + " CAD",
                                    "Total = $" + total + " CAD"};
        }
    }
}
