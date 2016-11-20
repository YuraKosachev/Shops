using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Service.Interfaces;
using Shops.Service.ServiceModel;

namespace Shops.Service.Services
{
    public class ShopService : Service, IShopService
    {
        public void Create(ShopServiceModel model)
        {
            Provider.ShopsProvider.Create();
        }

        public void Delete(ShopServiceModel model)
        {
            Provider.ShopsProvider.Delete();
        }

        public IEnumerable<ShopServiceModel> GetAll()
        {
           return  Provider.ShopsProvider.GetAll();
        }

        public ShopServiceModel GetItem(ShopServiceModel model)
        {
            return Provider.ShopsProvider.GetItem();
        }

        public IDictionary<int, string> GetShopsDictionary()
        {
            return Provider.ShopsProvider.GetShopsDictionary();
        }

        public void Update(ShopServiceModel model)
        {
            Provider.ShopsProvider.Update();
        }
    }
}
