using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Provider.Providers
{
    public abstract class Provider<TModel>
        where TModel:class
    {
        public virtual IEnumerable<TModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public virtual int Create(TModel model)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
