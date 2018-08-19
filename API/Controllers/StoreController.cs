using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application;
using Infrastructure.Models;

namespace c_sharp_learning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private IGreenhouse _greenhouse;
        private IStore _store;

        public StoreController(IGreenhouse greenhouse, IStore store)
        {
            _greenhouse = greenhouse;
            _store = store;

            long id1 = _store.AddProduct(new Product { Name = "Audi", Price = 3208.7 });
            long id2 = _store.AddProduct(new Product { Name = "Renault", Price = 3605.2 });
            long id3 = _store.AddProduct(new Product { Name = "Saab", Price = 1200.1 });
        }

        // GET api/store
        [HttpGet]
        public ActionResult<IEnumerable<IProduct>> Get()
        {
            var products = _store.GetAllProducts();
            return Ok(products);
        }

        // GET api/store/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            Product product = (Product)_store.GetProduct(id);

            if (product == null)
                return NotFound();
            else
                return product;
        }

        // Return types, https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.1  
        // Without known conditions to safeguard against during action execution, returning a specific type could suffice.
        // GET api/store/specificreturntype
        [HttpGet("specificreturntype")]
        public IEnumerable<int> GetSpecType()
        {
            List<int> list = new List<int> {1, 2, 3, 5, 8};
            return list;
        }

        /*
         * When known conditions need to be accounted for in an action, 
         * multiple return paths are introduced. 
         * In such a case, it's common to mix an ActionResult return
         * type with the primitive or complex return type. 
         */

        /*
         * ASP.NET Core 2.1 introduces the ActionResult<T> return type for Web API 
         * controller actions. It enables you to return a type deriving from 
         * ActionResult or return a specific type.
         */
        // GET api/store/somesyncaction/5
        [HttpGet("somesyncaction/{id}")]
        public ActionResult<int> GetById(int id)
        {
            if (id != 5)
            {
                return BadRequest();
            }

            // Implicit cast operators support the conversion of both T and ActionResult to ActionResult<T>.
            return id;
        }


        // GET api/store/someAsyncaction/5
        [HttpGet("someAsyncaction/{id}")]
        public async Task<ActionResult<Product>> GetByIdAsync(int id)
        {
            if (id != 5)
            {
                return BadRequest();
            }

            var product = await _store.GetProductAsync(id);

            return (Product)product; // Not possible when returning interfaces
        }


        // POST api/product
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/product/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
