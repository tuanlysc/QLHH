﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLHS.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        QLHS.Models.HieuSachEntities db = new QLHS.Models.HieuSachEntities();
        // GET: Admin/Category
        public ActionResult Index()
        {
            List<Models.category> data = db.categories.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(QLHS.Models.category obj)
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
                        string foder = Server.MapPath("~/Assets/Upload/" + fName);
                        fImage.SaveAs(foder);
                        obj.img =  fName;
                    }
                    db.categories.Add(obj);
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
            QLHS.Models.category existingcategory = db.categories.Find(id);

            if (existingcategory == null)
            {
                return HttpNotFound();
            }

            return View(existingcategory);
        }

        [HttpPost]
        public ActionResult Edit(QLHS.Models.category obj)
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
                        string folder = Server.MapPath("~/Assets/Upload/" + fName);
                        fImage.SaveAs(folder);
                        obj.img =  fName;
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
            QLHS.Models.category categoryToDelete = db.categories.Find(id);

            if (categoryToDelete == null)
            {
                return HttpNotFound();
            }

            db.categories.Remove(categoryToDelete);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

       
    }
}