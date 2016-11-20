using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.ModelProvider;
namespace Shops.Provider.UrlGenerate
{
    public interface IProductUrlGenerate:IUrlBuilder<ProductModelProvider>
    {
        string GetShopProductsUrl(ProductModelProvider model);
    }
}
