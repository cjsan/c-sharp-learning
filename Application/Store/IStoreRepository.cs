using System;
using System.Collections.Generic;
namespace Application
{
    public interface IStoreRepository
    {
        long AddProduct(IProduct product);
        IProduct GetProduct(long Id);
        IEnumerable<IProduct> GetAllProducts();
    }
}
