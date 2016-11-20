using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Service.Interfaces
{
    public interface IService<TModel>
        where TModel:class
    {
        IEnumerable<TModel> GetAll();
        TModel GetItem(TModel model);
        void Delete(TModel model);
        void Create(TModel model);
        void Update(TModel model);
    }
}
