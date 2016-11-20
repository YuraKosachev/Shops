using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.ModelProvider;

namespace Shops.Provider.UrlGenerate
{
    public class ProductUrlGenerate : UrlBuider, IProductUrlGenerate
    {
        public string CreateUrl()
        {
            return String.Format("{0}/{1}", GetApiHost, "api/Products");
        }

        public string DeleteUrl(ProductModelProvider model)
        {
            return String.Format("{0}/{1}/{2}", GetApiHost, "api/Products",model.ProductId);
        }

        //Put
        public string EditUrl()
        {
            return String.Format("{0}/{1}", GetApiHost, "api/Products");
        }

        public string GetAllUrl()
        {
            return String.Format("{0}/{1}", GetApiHost, "api/Products");
        }

        public string GetItem(ProductModelProvider model)
        {
            return String.Format("{0}/{1}/{2}", GetApiHost, "api/Products", model.ProductId);
        }

        public string GetShopProductsUrl(ProductModelProvider model)
        {
            return String.Format("{0}/{1}/{2}", GetApiHost, "api/Products", model.ShopId);
        }
    }
}
