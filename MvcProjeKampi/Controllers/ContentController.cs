﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager contentManager = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetAllContent(string p)
        {

            //var values = contentManager.GetList(p);
            //var values = context.Contents.ToList();
            if (p == null)
            {
                var values = contentManager.GetList();
                return View(values.ToList());
            }
            else
            {
                var values = contentManager.GetList(p);
                return View(values);
            }
            
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = contentManager.GetListByHeadingId(id);
            return View(contentvalues);
        }
    }
}