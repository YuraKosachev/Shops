using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shops.Models;

namespace Shops.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            var list = new List<ShopViewModel>();
            for (var i = 0;i<10;i++)
            {
                list.Add(new ShopViewModel {
                    ShopAddress = "Some address"+i,
                    ShopId = i,
                    ShopName ="Shop name"+i,
                    WorkingTime = "8.00 - 17.00"
                });
            }
            return View(list);
        }

    }
}
