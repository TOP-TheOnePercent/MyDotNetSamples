using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySecondApp.Controllers
{
    public class StudentsController : ApiController
    {
        [Route("api/student/getall")]
        public List<string> GetEmployees()
        {
            return new List<string>() { "Rohit", "Mughil", "Vineeth" };

        }
        [Route("api/welcome/{name}")]
        public string GetWelcomeText(string name)
        {
            return $"Hi Student {name}, Welcome for learning..";

        }
    }
}
