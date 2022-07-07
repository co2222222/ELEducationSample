using Microsoft.AspNetCore.Mvc;


namespace WebService.Controllers
{

        [ApiController]
        [Route("[controller]")]
        public class CalcController : ControllerBase
        {
            [HttpGet]
            [Route("CalcAdd/{a:int}/{b:int}")]
            public int CalcAdd([FromQuery] ELEducationSample.Calculator sc, int a, int b)
            {
                return sc.Add(a,b);
            }
            [HttpGet]
            [Route("CalcSubtract/{a:int}/{b:int}")]
            public int CalcSubtract([FromQuery] ELEducationSample.Calculator sc, int a, int b)
            {
                return sc.Subtract(a, b);
            }
            [HttpGet]
            [Route("CalcMultiply/{a:int}/{b:int}")]
            public int CalcMultiply([FromQuery] ELEducationSample.Calculator sc, int a, int b)
            {
                return sc.Multiply(a, b);
            }
            [HttpGet]
            [Route("CalcDivide/{a:int}/{b:int}")]
            public int CalcDivide([FromQuery] ELEducationSample.Calculator sc, int a, int b)
            {
                return sc.Divide(a, b);
            }
        }
}
