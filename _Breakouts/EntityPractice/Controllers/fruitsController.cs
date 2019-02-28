using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityPractice.Models;

namespace EntityPractice.Controllers
{
    public class fruitsController : Controller
    {
        //This is perhaps the most important part of this controller 
        //This db object is how we interact with the SQL database
        //It comes with a TOOOON of built in methods, many not covered 
        //here, but this code example covers many common cases/uses 
        //In your final project, you will most likely have to take and edit 
        //This controller
        private fruitEntities db = new fruitEntities();

       

        // GET: fruits
        public ActionResult Index()
        {
            //Note db contains pointers to alllll it's tables 
            //In this example I only have fruits, but I could access 
            //any table in my database
            return View(db.fruits.ToList());
            //return RedirectToAction("Index");
        }

        // GET: fruits/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //find grabs an individual row from fruits and stores it 
            //in a fruit model. Note the id is whatever the primary key is 
            //in this case it's a string
            fruit fruit = db.fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // GET: fruits/Create
        public ActionResult Create()
        {
            //This just gives me the view
            return View();
        }

        // POST: fruits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Quantity")] fruit fruit)
        {
            //This action is called when we hit the create button 
            //on the create view, note the HttpPost tag 
            if (ModelState.IsValid)
            {
                //This is how you add a row to your table 
                //It is two steps, first we add in the model (models are equivalent to rows)
                //Then we save changes 
                db.fruits.Add(fruit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //If for whatever reason the model isn't able to be added 
            //We loop back around to the same page, with error messages on the 
            //on the form detailing what's wrong
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
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
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

        //This takes you to the view 
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

        //This action actually does the deleting
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
