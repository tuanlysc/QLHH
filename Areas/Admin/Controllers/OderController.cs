using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLHS.Areas.Admin.Controllers
{
    [Authorize]
    public class OderController : Controller
    {
        Models.HieuSachEntities db = new Models.HieuSachEntities();
        // GET: Admin/Oder
        public ActionResult Index()
        {
            List<Models.order> data = db.orders.ToList();

            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.user_id = new SelectList(db.users.ToList(), "id", "user_id");

            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.order obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                   
                    db.orders.Add(obj);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch { }
            }
            ViewBag.user_id = new SelectList(db.users.ToList(), "id", "user_id");
            return View(obj);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Models.order existingorder = db.orders.Find(id);

            if (existingorder == null)
            {
                return HttpNotFound();
            }
            ViewBag.user_id = new SelectList(db.users.ToList(), "id", "user_id");
            return View(existingorder);
        }

        [HttpPost]
        public ActionResult Edit(Models.order obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    
                    db.Entry(obj).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch
                {
                    // Handle exceptions
                }
            }

            ViewBag.user_id = new SelectList(db.users.ToList(), "id", "user_id");
            return View(obj);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.order orderToDelete = db.orders.Find(id);

            if (orderToDelete == null)
            {
                return HttpNotFound();
            }

            return View(orderToDelete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Models.order orderToDelete = db.orders.Find(id);

            if (orderToDelete == null)
            {
                return HttpNotFound();
            }

            db.orders.Remove(orderToDelete);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}