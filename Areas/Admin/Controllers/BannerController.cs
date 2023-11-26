using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLHS.Areas.Admin.Controllers
{
    [Authorize]
    public class BannerController : Controller
    {
        Models.HieuSachEntities db = new Models.HieuSachEntities();
        // GET: Admin/Banner
        public ActionResult Index()
        {
            List<Models.banner> data = db.banners.ToList();

            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.banner obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var fImage = Request.Files["fImage"];
                    if (fImage != null && fImage.ContentLength > 0)
                    {
                        string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                        string fName = timeStamp + "_" + Path.GetFileName(fImage.FileName);
                        string foder = Server.MapPath("~/Assets/Uploads/" + fName);
                        fImage.SaveAs(foder);
                        obj.img = "~/Assets/Uploads/" + fName;
                    }
                    db.banners.Add(obj);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch { }
            }

            return View(obj);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Models.banner existingbanner = db.banners.Find(id);

            if (existingbanner == null)
            {
                return HttpNotFound();
            }

            return View(existingbanner);
        }

        [HttpPost]
        public ActionResult Edit(Models.banner obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var fImage = Request.Files["fImage"];
                    if (fImage != null && fImage.ContentLength > 0)
                    {

                        string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                        string fName = timeStamp + "_" + Path.GetFileName(fImage.FileName);
                        string folder = Server.MapPath("~/Assets/Uploads/" + fName);
                        fImage.SaveAs(folder);
                        obj.img = "~/Assets/Uploads/" + fName;
                    }

                    db.Entry(obj).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch
                {
                    // Handle exceptions
                }
            }


            return View(obj);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.banner bannerToDelete = db.banners.Find(id);

            if (bannerToDelete == null)
            {
                return HttpNotFound();
            }

            db.banners.Remove(bannerToDelete);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}