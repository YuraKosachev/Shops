using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Provider.ModelProvider
{
    public class ShopModelProvider
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public TimeSpan ShopOpeningTime { get; set; }
        public TimeSpan ShopClosingTime { get; set; }
    }
}
