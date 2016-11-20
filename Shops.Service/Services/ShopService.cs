using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Service.Interfaces;
using Shops.Service.ServiceModel;
using Shops.Provider.ModelProvider;
using AutoMapper;

namespace Shops.Service.Services
{
    public class ShopService : Service, IShopService
    {
        public ShopService():base()
        {
           
        }
        public void Create(ShopServiceModel model)
        {
            Provider.ShopsProvider.Create(Mapper.Map<ShopModelProvider>(model));
        }

        public void Delete(ShopServiceModel model)
        {
            Provider.ShopsProvider.Delete(Mapper.Map<ShopModelProvider>(model));
        }

        public IEnumerable<ShopServiceModel> GetAll()
        {
           return  Provider.ShopsProvider.GetAll().Select(shop=> Mapper.Map<ShopServiceModel>(shop));
        }

        public ShopServiceModel GetItem(ShopServiceModel model)
        {
            var modelProvider = Mapper.Map<ShopModelProvider>(model);
            var item = Provider.ShopsProvider.GetItem(modelProvider);
            return Mapper.Map<ShopServiceModel>(item);
        }

        public IDictionary<int, string> GetShopsDictionary()
        {
            return Provider.ShopsProvider.GetShopsDictionary();
        }

        public void Update(ShopServiceModel model)
        {
            Provider.ShopsProvider.Update(Mapper.Map<ShopModelProvider>(model));
        }

        protected override void MapperConf()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ShopServiceModel, ShopModelProvider>().ReverseMap());
        }
    }
}
