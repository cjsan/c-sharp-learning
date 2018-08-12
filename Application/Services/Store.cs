using System;
using System.Collections.Generic;
namespace Application
{
    public class Store : IStore
    {
        private IStoreRepository _storeRepository;

        public Store(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public long AddProduct(IProduct product)
        {
            var Id = _storeRepository.AddProduct(product);
            return Id;
        }

        public IProduct GetProduct(long Id)
        {
            var product = _storeRepository.GetProduct(Id);
            return product;
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            var products = _storeRepository.GetAllProducts();
            return products;
        }
    }
}
