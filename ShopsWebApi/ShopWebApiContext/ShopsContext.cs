using System;
using System.Collections.Generic;
using System.Data.Entity;
using ShopsWebApi.Models;
using System.Linq;
using System.Web;

namespace ShopsWebApi.ShopWebApiContext
{
    public class ShopsContext : DbContext
    {
        public ShopsContext() : base("Shops") { }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}