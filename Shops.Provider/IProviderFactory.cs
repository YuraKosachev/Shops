using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.Interfaces;

namespace Shops.Provider
{
    public interface IProviderFactory
    {
        IProductProvider ProductsProvider { get; }
        IShopProvider ShopsProvider { get; }
    }
}
