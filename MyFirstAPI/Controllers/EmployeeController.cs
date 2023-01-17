using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstAPI.Controllers
{

    public class EmployeeController : ApiController
    {
        public EmployeeController()
        {
        
        }

        [Route("api/employee/getall")]
        public List<string> GetEmployees()
        {
            return new List<string>() { "Rohit", "Mughil", "Vineeth"};

        }
        [Route("api/welcome/{name}")]
        public string GetWelcomeText(string name)
        {
            return $"Hi {name}, Welcome to learn .Net";

        }
    }
}
