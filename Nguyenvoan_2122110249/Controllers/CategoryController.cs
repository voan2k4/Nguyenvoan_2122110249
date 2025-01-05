using Nguyenvoan_2122110249.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nguyenvoan_2122110249.Controllers
{
    public class CategoryController : Controller
    {
        WebsiteBanHangEntities objWebsiteBanHangEntities = new WebsiteBanHangEntities();
        // GET: Category
        public ActionResult Category()
        {
            var lstCategory = objWebsiteBanHangEntities.Categories.ToList(); 
            return View();
        }
    }
}