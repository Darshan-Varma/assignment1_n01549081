using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1_n01549081.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Square of the integer
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Input number multiplied by itself</returns>
        /// <example>
        /// GET api/Square/2 -> 4
        /// GET api/Square/-2 -> 4
        /// GET api/Square/10 -> 100
        /// </example>
        // GET /api/Square/{id}
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
