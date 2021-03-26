using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class House_categeryController : Controller
    {
        private Model1Container2 db = new Model1Container2();

        // GET: House_categery
        public ActionResult Index()
        {
            return View(db.House_categery.ToList());
        }

        // GET: House_categery/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            House_categery house_categery = db.House_categery.Find(id);
            if (house_categery == null)
            {
                return HttpNotFound();
            }
            return View(house_categery);
        }

        // GET: House_categery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: House_categery/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,Quantity")] House_categery house_categery)
        {
            if (ModelState.IsValid)
            {
                db.House_categery.Add(house_categery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(house_categery);
        }

        // GET: House_categery/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            House_categery house_categery = db.House_categery.Find(id);
            if (house_categery == null)
            {
                return HttpNotFound();
            }
            return View(house_categery);
        }

        // POST: House_categery/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,Quantity")] House_categery house_categery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(house_categery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(house_categery);
        }

        // GET: House_categery/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            House_categery house_categery = db.House_categery.Find(id);
            if (house_categery == null)
            {
                return HttpNotFound();
            }
            return View(house_categery);
        }

        // POST: House_categery/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            House_categery house_categery = db.House_categery.Find(id);
            db.House_categery.Remove(house_categery);
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
