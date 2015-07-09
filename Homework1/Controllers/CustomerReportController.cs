using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class CustomerReportController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: CustomerReport
        public ActionResult Index()
        {
            return View(db.客戶統計.ToList());
        }

        // GET: CustomerReport/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶統計 客戶統計 = db.客戶統計.Find(id);
            if (客戶統計 == null)
            {
                return HttpNotFound();
            }
            return View(客戶統計);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
