using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using DietHolder2WebApplication.Models;

namespace DietHolder2WebApplication.Controllers
{
    public class CalculatorTdeeController : ApiController
    {
        public double Get()
        {
            var person = HttpContext.Current.Application.Get("person"); 

            if(person == null)
            {
                throw new ArgumentNullException();
            }
            return CalculatorTdee.GetTdee((Person)person);
        }
        public HttpResponseMessage Post([FromBody] Person value)
        {
            HttpContext.Current.Application["person"] = value; 

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
