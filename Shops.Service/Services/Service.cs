using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Provider;
using Shops.Provider.ModelProvider;
using AutoMapper;
using Shops.Service.ServiceModel;

namespace Shops.Service.Services
{
    public abstract class Service
    {
        public IProviderFactory Provider { get; set; }
        public Service()
        {
            Provider = new ProviderFactory();
            MapperConf();
        }
        protected abstract void MapperConf(); 
    }
}
