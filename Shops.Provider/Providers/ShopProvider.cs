using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.Interfaces;
using Shops.Provider.ModelProvider;
using Shops.Provider.UrlGenerate;
using System.Net.Http;
using Newtonsoft.Json;

namespace Shops.Provider.Providers
{
    public class ShopProvider : Provider<ShopModelProvider>, IShopProvider
    {
        public ShopProvider(IShopUrlGenerate urlBuilder):base(urlBuilder)
        {

        }
        public IDictionary<int, string> GetShopsDictionary()
        {
            using (var client = new HttpClient())
            {
                var message = client.GetAsync(urlBuilder.GetAllUrl()).Result;
                if (message.StatusCode == System.Net.HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<IDictionary<int, string>>(message.Content.ReadAsStringAsync().Result);

            }
            throw new Exception();

        }

    }
}
