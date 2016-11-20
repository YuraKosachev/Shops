using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shops.Models;
namespace Shops.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddProduct(int id)
        {
            var item = new ProductViewModel { ShopId = id};
            return View(item);
        }
        [HttpPost]
        public ActionResult AddProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult GetShopProducts(int id)
        {
            var list = new List<ProductViewModel>();
            for (var i = 0;i<10;i++)
            {
                list.Add(new ProductViewModel {
                    ShopId = 1,
                    ProductDescription = "Some Description"+i,
                    ProductId=i,
                    ProductName="Some product"+i
                });
            }
            return PartialView(list);
        }

    }
}
