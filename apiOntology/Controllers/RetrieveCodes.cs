using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;

namespace apiOntology.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetrieveCodes : ControllerBase
    {
        [EnableCors("Policy1")]
        [HttpGet]
        public IEnumerable<CancerCode> Get(string code)
        {
            CancerCode[] codes = {
                new CancerCode
                {
                    cancerId = 1,
                    cancerCode = "1234",
                    otherCode = "3456"
                },
                new CancerCode
                {
                    cancerId = 1,
                    cancerCode = "1234",
                    otherCode = "3456"
                }
            };

            return codes;
        }
    }
}
