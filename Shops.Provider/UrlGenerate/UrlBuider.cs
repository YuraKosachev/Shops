using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Provider.UrlGenerate
{
    public abstract class UrlBuider
    {
        public virtual string GetApiHost {
            get { return Properties.Settings.Default.WebApiHost; }
        }
    }
}
