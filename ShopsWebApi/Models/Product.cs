using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopsWebApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}