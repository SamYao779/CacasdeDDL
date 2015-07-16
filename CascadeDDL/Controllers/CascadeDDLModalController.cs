using CascadeDDLTest.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadeDDLTest.Controllers
{
    public class CascadeDDLModalController : Controller
    {
        CascadeDbContext db = new CascadeDbContext();
        //
        // GET: /CascadeDDLModal/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CascadeModal()
        {
            ViewBag.Cate = new SelectList(db.Categories, "Id", "Name");
            return PartialView("_CascadeModal");
        }

        [HttpPost]
        public ActionResult CascadeModal(int? Id)
        {
            var prod = db.Products.Where(p => p.CategoryId == Id);
            return Json(new SelectList(prod, "Id", "Name"));
        }
    }
}