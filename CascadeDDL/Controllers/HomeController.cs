using CascadeDDLTest.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadeDDLTest.Controllers
{
    public class HomeController : Controller
    {
        CascadeDbContext db = new CascadeDbContext();
        public ActionResult Index()
        {
            //db.Categories.Add(new Category { Name = "Nokia", Origin = "Phần Lan" });
            //db.Categories.Add(new Category { Name = "Apple", Origin = "Mỹ" });
            //db.Categories.Add(new Category { Name = "Samsung", Origin = "Hàn Quốc" });
            //db.Categories.Add(new Category { Name = "HTC", Origin = "Đài Loan" });
            //db.SaveChanges();
            //var model = db.Categories.ToList();
            return View();
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