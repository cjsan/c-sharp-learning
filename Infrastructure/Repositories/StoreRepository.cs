using System;
using Application;
using Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<IProduct> GetAllProducts()
        {
            var products = _storeContext.Products.ToList();
            return products;
        }
    }
}
