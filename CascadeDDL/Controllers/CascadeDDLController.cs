using CascadeDDLTest.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadeDDLTest.Controllers
{
    public class CascadeDDLController : Controller
    {
        CascadeDbContext db = new CascadeDbContext();
        //
        // GET: /CascadeDDL/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CascadeCategory()
        {
            ViewBag.Cate = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        public ActionResult CascadeProduct(int? Id)
        {
            var prod = db.Products.Where(p => p.CategoryId == Id);
            return Json(new SelectList(prod, "Id", "Name"),JsonRequestBehavior.AllowGet);
        }
	}
}