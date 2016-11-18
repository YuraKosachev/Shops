using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Provider.Interfaces
{
    public interface IProvider<TModel>
        where TModel:class
    {
        IEnumerable<TModel> GetAll();
        void Delete(TModel model);
        int Create(TModel model);
        void Update(TModel model);
    }
}
