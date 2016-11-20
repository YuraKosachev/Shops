using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Service.Interfaces;
namespace Shops.Service
{
    public interface IServiceFactory
    {
        IShopService ShopService { get; }
        IProductService ProductService { get; }
    }
}
