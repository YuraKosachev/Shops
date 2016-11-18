using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net.Http.Formatting;
using System.Net.Http;
using System.Net;
using System.IO;

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
            string url = "http://localhost:31099/api/Shops";
            Shop shop = new Shop
            {
                ShopAddress = "jaskdjkalsd",
                ShopClosingTime = TimeSpan.FromHours(2),
                ShopOpeningTime = TimeSpan.FromHours(10),
                ShopName = "SomeName"
            };
            HttpResponseMessage message;
            using (var client = new HttpClient())
            {
                message = client.PostAsJsonAsync<Shop>(url,shop).Result;
                //var response =
                //    client.PostAsync(APP_PATH + "/Token", content).Result;
                //var result = response.Content.ReadAsStringAsync().Result;
                //// Десериализация полученного JSON-объекта
                //Dictionary<string, string> tokenDictionary =
                //    JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                //return tokenDictionary;
            }
            Console.WriteLine(message);
            Console.ReadLine();
            
        }
    }
}
