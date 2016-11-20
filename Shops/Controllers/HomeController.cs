using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shops.Models;
using Shops.Service.ServiceModel;
using AutoMapper;

namespace Shops.Controllers
{
    public class HomeController : AppController
    {
        //
        // GET: /Home/
        public HomeController():base(){}
        public ActionResult Index()
        {

            //var list = new List<ShopViewModel>();
            //for (var i = 0;i<10;i++)
            //{
            //    list.Add(new ShopViewModel {
            //        ShopAddress = "Some address"+i,
            //        ShopId = i,
            //        ShopName ="Shop name"+i,
            //        WorkingTime = "8.00 - 17.00"
            //    });
            //}
            var list1 = Service.ShopService.GetAll();
            var list = list1.Select(shop=>Mapper.Map<ShopViewModel>(shop));
            return View(list);
        }

        protected override void MapperConf()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ShopServiceModel,ShopViewModel>()
            .ForMember("WorkingTime",opt=>opt.MapFrom(shop=>String.Format("{0} - {1}",shop.ShopOpeningTime,shop.ShopClosingTime))));
            Mapper.Initialize(cfg => cfg.CreateMap<ShopServiceModel, CreateShopViewModel>().ReverseMap());
        }
    }
}
