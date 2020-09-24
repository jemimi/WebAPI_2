using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_2.Controllers
{
    public class PostGreetingController : ApiController
    {
    


        /// <summary>
        /// <example> POST /api/Greeting/</example>
        /// open command prompt
        /// type curl "http://localhost:60340/api/PostGreeting/"
        /// curl -d " " "http://localhost:60340/api/PostGreeting/"
        /// </summary>
        /// <returns>"Hello World"</returns>
        public string Post()

        { 
            return  "Hello World" ; 
        }

    }
}
