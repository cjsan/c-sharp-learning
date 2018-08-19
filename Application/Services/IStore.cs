using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IStore
    {
        long AddProduct(IProduct product);
        IProduct GetProduct(long Id);
        Task<IProduct> GetProductAsync(long Id);
        IEnumerable<IProduct> GetAllProducts();
    }
}
