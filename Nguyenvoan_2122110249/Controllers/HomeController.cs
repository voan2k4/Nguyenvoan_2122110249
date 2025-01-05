using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nguyenvoan_2122110249.Context;
using Nguyenvoan_2122110249.Models;

namespace Nguyenvoan_2122110249.Controllers
{
    public class HomeController : Controller
    {
        WebsiteBanHangEntities objWebsiteBanHangEntities = new WebsiteBanHangEntities();
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();


            objHomeModel.ListCategory = objWebsiteBanHangEntities.Categories.ToList();

            objHomeModel.ListProduct = objWebsiteBanHangEntities.Products.ToList();

            return View(objHomeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}