using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math_Web_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {

        //the
        [HttpGet]
        public double Addition(int lValue , int rValue)
        {
            return lValue + rValue;
        }

        [HttpGet]
        public double Subtraction(int lValue, int rValue)
        {
            return lValue - rValue;
        }

        [HttpGet]
        public double Multiplication(int lValue, int rValue)
        {
            return lValue * rValue;
        }

        [HttpGet]
        public double Division(int lValue, int rValue)
        {
            if(lValue==0 || rValue == 0)
            {
                throw new ArgumentException("Cannot Divide By 0");
            }
            else
            {
                return lValue / rValue;

            }
            
        }

    }
}
