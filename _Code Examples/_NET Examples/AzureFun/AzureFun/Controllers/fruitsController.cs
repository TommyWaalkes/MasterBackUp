using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AzureFun.Models;

namespace AzureFun.Controllers
{
    public class fruitsController : Controller
    {
        private fruitEntities db = new fruitEntities();

        // GET: fruits
        public ActionResult Index()
        {
            return View(db.fruits.ToList());
        }

        // GET: fruits/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fruit fruit = db.fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            else
            {
              fruit.Quantity = fruit.Quantity + 1;
                //db.fruits.
              db.SaveChanges();
            }
            return View(fruit);
        }

        // GET: fruits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: fruits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Quantity")] fruit fruit)
        {
            if (ModelState.IsValid)
            {
                //ViewBag.recentConcerts += "<li>" + concertInfo + " " + "<input type=\"button\" value=\"Go to Concert\" onclick=\"location.href = '<%: Url.Action(\"Concert\", \"Setlist\", new { parameter1 = \"concert\" }) %> </ li > ";


                db.fruits.Add(fruit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fruit);
        }

        // GET: fruits/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fruit fruit = db.fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: fruits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Quantity")] fruit fruit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fruit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fruit);
        }

        // GET: fruits/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fruit fruit = db.fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: fruits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            fruit fruit = db.fruits.Find(id);
            db.fruits.Remove(fruit);
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
