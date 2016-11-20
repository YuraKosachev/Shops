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
    public class ProductService : Service, IProductService
    {
        public ProductService():base() { }

        public void Create(ProductServiceModel model)
        {
            Provider.ProductsProvider.Create(Mapper.Map<ProductModelProvider>(model));
        }

        public void Delete(ProductServiceModel model)
        {
            Provider.ProductsProvider.Delete(Mapper.Map<ProductModelProvider>(model));
        }

        public IEnumerable<ProductServiceModel> GetAll()
        {
            return Provider.ProductsProvider.GetAll().Select(product => Mapper.Map<ProductServiceModel>(product));
        }

        public ProductServiceModel GetItem(ProductServiceModel model)
        {
            var modelProvider = Mapper.Map<ProductModelProvider>(model);
            var item = Provider.ProductsProvider.GetItem(modelProvider);
            return Mapper.Map<ProductServiceModel>(item);
        }

        public IEnumerable<ProductServiceModel> GetShopProducts(ProductServiceModel model)
        {
            var modelProvider = Mapper.Map<ProductModelProvider>(model);
            return Provider.ProductsProvider.GetShopProducts(modelProvider).Select(product => Mapper.Map<ProductServiceModel>(product));
        }

        public void Update(ProductServiceModel model)
        {
            Provider.ProductsProvider.Update(Mapper.Map<ProductModelProvider>(model));
        }

        protected override void MapperConf()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ProductServiceModel, ProductModelProvider>().ReverseMap());
        }
    }
}
