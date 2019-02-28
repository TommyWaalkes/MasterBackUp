using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DBFirstDemo.Models;

namespace DBFirstDemo.Controllers
{
    public class WoodsController : Controller
    {
        private WoodEntities db = new WoodEntities();

        // GET: Woods
        public ActionResult Index()
        {
            return View(db.Woods.ToList());
        }

        // GET: Woods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wood wood = db.Woods.Find(id);
            if (wood == null)
            {
                return HttpNotFound();
            }
            return View(wood);
        }

        // GET: Woods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Woods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,WoodType,Price,Weight")] Wood wood)
        {
            if (ModelState.IsValid)
            {
                db.Woods.Add(wood);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wood);
        }

        // GET: Woods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wood wood = db.Woods.Find(id);
            if (wood == null)
            {
                return HttpNotFound();
            }
            return View(wood);
        }

        // POST: Woods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,WoodType,Price,Weight")] Wood wood)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wood).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wood);
        }

        // GET: Woods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wood wood = db.Woods.Find(id);
            if (wood == null)
            {
                return HttpNotFound();
            }
            return View(wood);
        }

        // POST: Woods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wood wood = db.Woods.Find(id);
            db.Woods.Remove(wood);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ListWood()
        {
            List<Wood> woods = db.Woods.ToList();

            ViewBag.woodList = woods;
            return View();
        }

        public ActionResult WoodListTemplate()
        {
            //List<Wood> woods = db.Woods.ToList();
            List<Wood> woods = new List<Wood>();
            Wood w = new Wood();
            w.Price = 1;
            w.Weight = 4;
            w.WoodType = "Tree";
            woods.Add(w);
            
            return View(woods);
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
