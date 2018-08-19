using System;
using Application;
using Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        StoreContext _storeContext;

        public StoreRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public long AddProduct(IProduct product)
        {
            Product p = (Product) product;
            _storeContext.Products.Add(p);
            _storeContext.SaveChanges();
            return p.Id;                                       
        }

        public IProduct GetProduct(long Id)
        {
            var product = _storeContext.Products.Find(Id);
            return product;
        }

        public async Task<IProduct> GetProductAsync(long Id)
        {
            var product = await _storeContext.Products.FindAsync(Id);
            return product;
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            var products = _storeContext.Products.ToList();
            return products;
        }
    }
}
