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
    public class House_categoryController : Controller
    {
        private Model1Container2 db = new Model1Container2();

        // GET: House_category
        public ActionResult Index()
        {
            return View(db.House_category.ToList());
        }

        // GET: House_category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            House_category house_category = db.House_category.Find(id);
            if (house_category == null)
            {
                return HttpNotFound();
            }
            return View(house_category);
        }

        // GET: House_category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: House_category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,Quantity")] House_category house_category)
        {
            if (ModelState.IsValid)
            {
                db.House_category.Add(house_category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(house_category);
        }

        // GET: House_category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            House_category house_category = db.House_category.Find(id);
            if (house_category == null)
            {
                return HttpNotFound();
            }
            return View(house_category);
        }

        // POST: House_category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,Quantity")] House_category house_category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(house_category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(house_category);
        }

        // GET: House_category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            House_category house_category = db.House_category.Find(id);
            if (house_category == null)
            {
                return HttpNotFound();
            }
            return View(house_category);
        }

        // POST: House_category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            House_category house_category = db.House_category.Find(id);
            db.House_category.Remove(house_category);
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
