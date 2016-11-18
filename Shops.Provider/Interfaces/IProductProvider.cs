using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.ModelProvider;

namespace Shops.Provider.Interfaces
{
    public interface IProductProvider:IProvider<ProductModelProvider>
    {
        IEnumerable<ProductModelProvider> GetShopProducts(int id);
    }
}
