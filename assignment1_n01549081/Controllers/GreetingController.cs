using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1_n01549081.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Display Hello world message
        /// </summary>
        /// <returns>Hello World</returns>
        /// curl -d "" localhost:55992/api/Greeting
        /// POST api/Greeting -> "Hello World!"
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Greetings to people
        /// </summary>
        /// <param name="id">Number of people as Input number</param>
        /// <returns>Greetings to number of people entered as input</returns>
        /// <example>
        /// GET api/Greeting/3 -> "Greetings to 3 people!"
        /// GET api/Greeting/6 -> "Greetings to 6 people!"
        /// GET api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        /// // GET /api/Greeting/{id}
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
