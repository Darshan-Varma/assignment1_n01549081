using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1_n01549081.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Add ten to input
        /// </summary>
        /// <param name="id">Input number</param>
        /// <returns>Input number plus 10</returns>
        /// <example>
        /// GET api/AddTen/11 -> 21
        /// GET api/AddTen/0 -> 10
        /// GET api/AddTen/-9 -> 1
        /// </example>
        // GET /api/AddTen/{id}
        public int Get(int id)
        {
            int addition = id + 10;
            return addition;
        }
    }
}
