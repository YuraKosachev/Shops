using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.Interfaces;
using Shops.Provider.Providers;
using Shops.Provider.UrlGenerate;
namespace Shops.Provider
{
    public class ProviderFactory : IProviderFactory
    {
        public IProductProvider ProductsProvider
        {
            get
            {
                return new ProductProvider(new ProductUrlGenerate() );
            }
        }

        public IShopProvider ShopsProvider
        {
            get
            {
                return new ShopProvider(new ShopUrlGenerate());
            }
        }
    }
}
