using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopsWebApi.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public TimeSpan ShopOpeningTime { get; set; }
        public TimeSpan ShopClosingTime { get; set; }
        public virtual ICollection<Product> Products { get; set; } 
    }
}