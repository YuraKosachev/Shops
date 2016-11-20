using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Provider.UrlGenerate
{
    public interface IUrlBuilder<TModel>
        where TModel:class
    {
        string GetAllUrl();
        string GetItem(TModel model);
        string CreateUrl();
        string DeleteUrl(TModel model);
        string EditUrl();
    }
}
