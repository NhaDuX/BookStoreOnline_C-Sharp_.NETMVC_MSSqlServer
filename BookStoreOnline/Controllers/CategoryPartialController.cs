﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{   
    public class CategoryPartialController : Controller
    {
        BookStore db = new BookStore();
        // GET: CategoryPartial
        public ActionResult GetPartialCategoryNav()
        {
            ViewBag.CateList = db.Category.ToList();
            return PartialView();
        }

        public ActionResult GetCategorySelection()
        {
            ViewBag.CateList = db.Category.ToList();
            return PartialView();
        }
    }
}