using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }


        public List<Categories> BlogList()
        {
            List<Categories> categories = new List<Categories>();
            categories.Add(new Categories()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            categories.Add(new Categories()
            {
                CategoryName = "Seyahat",
                CategoryCount = 4
            });
            categories.Add(new Categories()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 7
            });
            categories.Add(new Categories()
            {
                CategoryName = "Spor",
                CategoryCount = 2
            });

            return categories;
        }
    }
}