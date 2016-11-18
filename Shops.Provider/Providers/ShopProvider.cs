using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.Interfaces;
using Shops.Provider.ModelProvider;

namespace Shops.Provider.Providers
{
    public class ShopProvider : Provider<ShopModelProvider>, IShopProvider
    {
        public IDictionary<int, string> GetShopsDictionary()
        {
            throw new NotImplementedException();
        }

    }
}
