using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider.UrlGenerate;
using System.Net.Http;
using Newtonsoft.Json;

namespace Shops.Provider.Providers
{
  
    public abstract class Provider<TModel>
        where TModel:class
    {
        public IUrlBuilder<TModel> urlBuilder;
        

        public Provider(IUrlBuilder<TModel> _urlBuilder)
        {
            urlBuilder = _urlBuilder;
        }
        public virtual IEnumerable<TModel> GetAll()
        {
            
            using (var client = new HttpClient())
            {
                var message = client.GetAsync(urlBuilder.GetAllUrl()).Result;
                    if(message.StatusCode == System.Net.HttpStatusCode.OK)
                        return JsonConvert.DeserializeObject<IEnumerable<TModel>>(message.Content.ReadAsStringAsync().Result);
                
            }
            return Enumerable.Empty<TModel>();
        }
        public virtual TModel GetItem(TModel model)
        {
            using (var client = new HttpClient())
            {
                var message = client.GetAsync(urlBuilder.GetItem(model)).Result;
                if (message.StatusCode == System.Net.HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<TModel>(message.Content.ReadAsStringAsync().Result);

            }
            throw new Exception();
        }
        public virtual void Delete(TModel model)
        {
            using (var client = new HttpClient())
            {
                var message = client.DeleteAsync(urlBuilder.DeleteUrl(model)).Result;
                if (message.StatusCode == System.Net.HttpStatusCode.NotFound)
                    throw new Exception();
            }
        }

        public virtual void Create(TModel model)
        {
           
            using (var client = new HttpClient())
            {
               var message = client.PostAsJsonAsync(urlBuilder.CreateUrl(), model).Result;
                if (message.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    throw new Exception();
            }
        }

        public virtual void Update(TModel model)
        {
            using (var client = new HttpClient())
            {
                var message = client.PutAsJsonAsync(urlBuilder.EditUrl(), model).Result;
                if (message.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    throw new Exception();
                if (message.StatusCode == System.Net.HttpStatusCode.NotFound)
                    throw new Exception();
            }
        }
    }
}
