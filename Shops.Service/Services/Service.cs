using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider;

namespace Shops.Service.Services
{
    public abstract class Service
    {
        public IProviderFactory Provider { get; set; }
    }
}
