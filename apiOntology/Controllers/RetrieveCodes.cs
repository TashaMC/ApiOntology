using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using apiOntology.Models;

namespace apiOntology.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetrieveCodes : ControllerBase
    {
        [EnableCors("Policy1")]
        [HttpGet]
        public IEnumerable<Code> Get(string passedCode)
        {
            Code[] code = {
                new Code
                {
                    Id = 1,
                    CancerCode = "1234",
                    OtherCode = "3456"
                },
                new Code
                {
                    Id = 1,
                    CancerCode = "1234",
                    OtherCode = "3456"
                }
            };

            return code;
        }
    }
}
