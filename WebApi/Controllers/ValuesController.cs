using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private List<string> valuesObj = new List<string>()
        {
            "value1",
            "value2",
            "value3"
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return valuesObj;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return valuesObj[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            valuesObj.Add(value);
            Console.WriteLine("ValueObj : ", valuesObj);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            valuesObj[id] = value;
            Console.WriteLine("ValueObj : ", valuesObj);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            valuesObj.RemoveAt(id);
            Console.WriteLine("ValueObj : ", valuesObj);
        }
    }
}
