using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppDemo.Helpers;

namespace WebAppDemo.Controllers
{
    public class FizzBuzzController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetFizzBuzz(string input)
        {
            try
            {

                if (input == null)
                {
                    throw new Exception("Empty input detected.");
                }

                var inputList = input.Split(',');

                var output = FizzBuzzHelper.Print(inputList);

                return Ok(output);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
