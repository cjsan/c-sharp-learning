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

        // GET api/product/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            Product product = (Product)_store.GetProduct(id);

            if (product == null)
                return NotFound();
            else
                return product;
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
