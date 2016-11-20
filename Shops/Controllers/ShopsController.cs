using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shops.Models;

namespace Shops.Controllers
{
    public class ShopsController : Controller
    {
        //
        // GET: /Shops/
        [HttpGet]
        public ActionResult AddNewShop()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewShop(CreateShopViewModel model)
        {
            if (ModelState.IsValid)
            {
                var time = model.ShopClosingTime.TimeOfDay;//return TimeSpan
                return RedirectToAction("Index", "Home");
            }
            
            return View();
        }

    }
}
