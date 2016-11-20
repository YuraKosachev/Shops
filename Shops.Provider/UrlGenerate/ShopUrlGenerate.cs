using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.ModelProvider;

namespace Shops.Provider.UrlGenerate
{
    public class ShopUrlGenerate : UrlBuider, IShopUrlGenerate
    {
        public string CreateUrl()
        {
            return String.Format("{0}/{1}", GetApiHost, "api/Shops");
        }

        public string DeleteUrl(ShopModelProvider model)
        {
            return String.Format("{0}/{1}/{2}", GetApiHost, "api/Shops",model.ShopId);
        }
        //Put
        public string EditUrl()
        {
            return String.Format("{0}/{1}", GetApiHost, "api/Shops");
        }

        public string GetAllUrl()
        {
            return String.Format("{0}/{1}", GetApiHost, "api/Shops");
        }

        public string GetItem(ShopModelProvider model)
        {
            return String.Format("{0}/{1}/{2}", GetApiHost, "api/Shops",model.ShopId);
        }

        public string GetUrlShopsDictionary()
        {
            return String.Format("{0}/{1}", GetApiHost, "api/ShopsDictionary");
        }
    }
}
