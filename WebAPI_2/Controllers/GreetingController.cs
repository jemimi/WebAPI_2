using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_2.Controllers
{
    public class GreetingController : ApiController
    {
        //GET api/Greeting/{id}
        public string Get(int id){
            string a = "Greetings to " + id + " people!";

            return a;

        }
    }
}
