using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Shops.Provider.ModelProvider;
using Shops.Provider.Interfaces;
using Shops.Provider.UrlGenerate;

namespace Shops.Provider.Providers
{
    public class ProductProvider : Provider<ProductModelProvider>, IProductProvider
    {
        public ProductProvider(IProductUrlGenerate urlBuilder) : base(urlBuilder) { }
        public IEnumerable<ProductModelProvider> GetShopProducts(ProductModelProvider model)
        {
            using (var client = new HttpClient())
            {
                var message = client.GetAsync(urlBuilder.GetAllUrl()).Result;
                if (message.StatusCode == System.Net.HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<IEnumerable<ProductModelProvider>>(message.Content.ReadAsStringAsync().Result);

            }
            return Enumerable.Empty<ProductModelProvider>();
        }
    }
}
