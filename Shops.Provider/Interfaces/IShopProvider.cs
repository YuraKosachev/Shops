using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.ModelProvider;

namespace Shops.Provider.Interfaces
{
    public interface IShopProvider:IProvider<ShopModelProvider>
    {
        IDictionary<int,string> GetShopsDictionary();
    }
}
