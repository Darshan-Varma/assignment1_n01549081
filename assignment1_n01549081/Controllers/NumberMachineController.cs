using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1_n01549081.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Applying mathematical operations to a number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Input number plus 10, and then subtract 20 from it, multiply it by 10, and divide it by 2</returns>
        /// <example>
        /// GET api/NumberMachine/20 -> 50
        /// GET api/NumberMachine/15 -> 25
        /// GET api/NumberMachine/100 -> 450
        /// </example>
        // GET /api/NumberMachine/{id}
        public int Get(int id)
        {
            int sum = id + 10;
            int diff = sum - 20;
            int mul = diff * 10;
            int div = mul / 2;
            return div;
        }
    }
}
