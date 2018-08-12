using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application;

namespace c_sharp_learning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IGreenhouse _greenhouse;

        public ValuesController(IGreenhouse greenhouse)
        {
            _greenhouse = greenhouse;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _greenhouse.SetSquareMeters(8);
            var tallPlants = _greenhouse.GetPlantsTallerThan(0.9);

            // https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.1
            return tallPlants.ToList();

            //return new string[] { "value1", "value2", _greenhouse.GetSquareMeters().ToString() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
