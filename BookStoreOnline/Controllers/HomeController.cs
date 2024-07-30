using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{
    public class HomeController : Controller
    {
        BookStore db = new BookStore();
        public ActionResult Index(int? page)
        {
            var book = db.Product.OrderByDescending(p=>p.ProductName);
            int pageSize = 16;
            int pageNum = (page ?? 1);
            return View(book.ToPagedList(pageNum,pageSize));
        }
    }
}