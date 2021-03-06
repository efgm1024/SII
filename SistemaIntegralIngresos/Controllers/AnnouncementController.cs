﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaIntegralIngresos.Models;

namespace SistemaIntegralIngresos.Controllers
{
    public class AnnouncementController : Controller
    {
        private SIIDbContext db = new SIIDbContext();

        //
        // GET: /Announcement/

        public ActionResult Index()
        {
            return View(db.Announcements.ToList());
        }

        //
        // GET: /Announcement/Details/5

        public ActionResult Details(int id = 0)
        {
            Announcement announcement = db.Announcements.Find(id);
            if (announcement == null)
            {
                return HttpNotFound();
            }
            return View(announcement);
        }

        //
        // GET: /Announcement/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Announcement/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                db.Announcements.Add(announcement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(announcement);
        }

        //
        // GET: /Announcement/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Announcement announcement = db.Announcements.Find(id);
            if (announcement == null)
            {
                return HttpNotFound();
            }
            return View(announcement);
        }

        //
        // POST: /Announcement/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(announcement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(announcement);
        }

        //
        // GET: /Announcement/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Announcement announcement = db.Announcements.Find(id);
            if (announcement == null)
            {
                return HttpNotFound();
            }
            return View(announcement);
        }

        //
        // POST: /Announcement/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Announcement announcement = db.Announcements.Find(id);
            db.Announcements.Remove(announcement);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}