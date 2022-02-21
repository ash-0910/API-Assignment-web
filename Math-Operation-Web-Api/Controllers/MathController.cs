using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math_Operation_Web_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        //Addition method
        [HttpGet]
        public double Addition(int lValue, int rValue)
        {
            return lValue + rValue;
        }

        //subtraction method
        [HttpGet]
        public double Subtraction(int lValue, int rValue)
        {
            return lValue - rValue;
        }

        //multiplication method
        [HttpGet]
        public double Multiplication(int lValue, int rValue)
        {
            return lValue * rValue;
        }

        //division method 
        [HttpGet]
        public double Division(int lValue, int rValue)
        {

            //checking if any value is 0 
            if (lValue == 0 || rValue == 0)
            {
                //if yes then throw exception
                throw new ArgumentException("Cannot Divide By 0");
            }
            else
            {

                //else divide the value and return 
                return lValue / rValue;

            }

        }
    }
}
