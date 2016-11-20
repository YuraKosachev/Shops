using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Service.Interfaces;
using Shops.Service.Services;

namespace Shops.Service
{
    public class ServiceFactory : IServiceFactory
    {
        public IProductService ProductService
        {
            get
            {
               return new ProductService();
            }
        }

        public IShopService ShopService
        {
            get
            {
               return new ShopService();
            }
        }
    }
}
