using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace WebAPI_2.Controllers
{
    public class AddTenController : ApiController
    {
        // GET api/AddTen/{id}
        public int Get(int id)
        {
            int sum = id + 10;
            return sum; 
        }
    }
}
