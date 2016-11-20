using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Shops.Provider;

namespace ConsoleApplication1
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public TimeSpan ShopOpeningTime { get; set; }
        public TimeSpan ShopClosingTime { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "http://localhost:31099/api/Shops";
            //Shop shop = new Shop
            //{
            //    ShopAddress = "jaskdjkalsd",
            //    ShopClosingTime = TimeSpan.FromHours(2),
            //    ShopOpeningTime = TimeSpan.FromHours(10),
            //    ShopName = "SomeName"
            //};
            //HttpResponseMessage message;
            //IEnumerable<Shop> obj;
            //using (var client = new HttpClient())
            //{
            //    message = client.PostAsJsonAsync<Shop>(url,shop).Result;
            //  message = client.GetAsync(url).Result;
            //    var st = message.StatusCode;
            //    var result = message.Content.ReadAsStringAsync().Result;
            //    obj = JsonConvert.DeserializeObject<IEnumerable<Shop>>(message.Content.ReadAsStringAsync().Result);
            //    //var response =
            //    //    client.PostAsync(APP_PATH + "/Token", content).Result;
            //    //var result = response.Content.ReadAsStringAsync().Result;
            //    //// Десериализация полученного JSON-объекта
            //    //Dictionary<string, string> tokenDictionary =
            //    //    JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            //    //return tokenDictionary;
            //}

            IProviderFactory provider = new ProviderFactory();

            var obj = provider.ShopsProvider.GetAll();

            foreach (var item in obj) 
            Console.WriteLine(item.ShopAddress);
            Console.ReadLine();
            
        }
    }
}
