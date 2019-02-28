using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TaskListBreakout.Models;

namespace TaskListBreakout.Controllers
{
    public class TaskListController : Controller
    {
        private TaskListContext db = new TaskListContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            List<User> users = db.Users.ToList();

            foreach(User u in users)
            {
                if(IsValidLogin(UserName, Password, u))
                {
                    Session["User"] = u;
                    Session["Name"] = UserName;
                    return RedirectToAction("TaskList");
                }
            }
            ViewBag.Error = "Login was not Successful Please Try again";
            return View();
        }

        public bool IsValidLogin(string UserName, string Password, User u)
        {
            if(u.UserName == UserName && u.Password == Password)
            {
                return true;
            }

            return false;
        }

        public bool IsLoggedIn()
        {
            if (Session["User"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Login");
        }

        public ActionResult TaskList()
        {
            if (IsLoggedIn())
            {
                User u = (User)Session["User"];
                int id = u.ID;
                List<Task> tasks = db.Tasks.ToList();
                List<Task> output = new List<Task>();

                foreach (Task t in tasks)
                {
                    if (t.UserID == id)
                    {
                        output.Add(t);
                    }
                }
                return View(output);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTask(string Description, DateTime DueDate)
        {
            Task t = new Task();
            t.Description = Description;
            t.DueDate = DueDate;
            t.Complete = false;
            User currentUser = (User) Session["User"];
            t.UserID = currentUser.ID;

            db.Tasks.Add(t);
            db.SaveChanges();
            return RedirectToAction("TaskList");
        }

        // GET: TaskList
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: TaskList/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: TaskList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: TaskList/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: TaskList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: TaskList/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: TaskList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
