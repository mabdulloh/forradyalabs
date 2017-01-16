using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoogleMapApp.Models;

namespace GoogleMapApp.Controllers
{
    public class HomeLocationsController : Controller
    {
        private GoogleMapEntities db = new GoogleMapEntities();

        // GET: HomeLocations
        public ActionResult Index()
        {
            return View(db.HomeLocation.ToList());
        }

        // GET: HomeLocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeLocation homeLocation = db.HomeLocation.Find(id);
            if (homeLocation == null)
            {
                return HttpNotFound();
            }
            return View(homeLocation);
        }

        // GET: HomeLocations/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult ViewHomeLocation()
        {
            return View();
        }

        // POST: HomeLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TipeRumah,AlamatRumah,Latitude,Longitude")] HomeLocation homeLocation)
        {
            if (ModelState.IsValid)
            {
                db.HomeLocation.Add(homeLocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeLocation);
        }

        // GET: HomeLocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeLocation homeLocation = db.HomeLocation.Find(id);
            if (homeLocation == null)
            {
                return HttpNotFound();
            }
            return View(homeLocation);
        }

        // POST: HomeLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TipeRumah,AlamatRumah,Latitude,Longitude")] HomeLocation homeLocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeLocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeLocation);
        }

        // GET: HomeLocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeLocation homeLocation = db.HomeLocation.Find(id);
            if (homeLocation == null)
            {
                return HttpNotFound();
            }
            return View(homeLocation);
        }

        // POST: HomeLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeLocation homeLocation = db.HomeLocation.Find(id);
            db.HomeLocation.Remove(homeLocation);
            db.SaveChanges();
            return RedirectToAction("Index");
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
