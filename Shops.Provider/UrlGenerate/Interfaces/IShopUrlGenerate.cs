using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.ModelProvider;
namespace Shops.Provider.UrlGenerate
{
    public interface IShopUrlGenerate:IUrlBuilder<ShopModelProvider>
    {
        string GetUrlShopsDictionary();
    }
}
