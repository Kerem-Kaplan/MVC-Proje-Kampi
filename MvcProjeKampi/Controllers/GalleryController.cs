using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery

        ImageFilesManager ImageFilesManager = new ImageFilesManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = ImageFilesManager.GetList();
            return View(files);
        }
    }
}