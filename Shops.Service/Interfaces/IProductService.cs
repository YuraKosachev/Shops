using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Service.ServiceModel;

namespace Shops.Service.Interfaces
{
    public interface IProductService:IService<ProductServiceModel>
    {
        IEnumerable<ProductServiceModel> GetShopProducts(ProductServiceModel model);
    }
}
