using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRegistrationHelper _registrationHelper;
        public ValuesController(IRegistrationHelper registrationHelper)
        {
            _registrationHelper = registrationHelper;
        }

        [HttpPost("test")]
        public string Test([FromBody] Test num)
        {
            _registrationHelper.Register(num.Name);
            return num.Name;
        }
    }

    public class Test
    {
        public string Name { get; set; }
    }
}
