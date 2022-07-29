using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudOperationWithEntity.Models;
using System.Net;

namespace CrudOperationWithEntity.Controllers
{
    public class EmployeeController : Controller
    {
        EmpContext db = new EmpContext();
        // GET: Employee
        public ViewResult Index()
        {
            IEnumerable<Emp> li = new List<Emp>();
            li = db.emptable.ToList();
            return View(li);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) 
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "id is required");
            }

            var data = db.emptable.Find(id);
            if (data == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Data not found");
            }

            return View(data);
        }

       
        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(Emp emp)
        {

            db.emptable.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "id is required");
            }

            var data = db.emptable.Find(id);
            if (data == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Data not found");
            }
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            Emp emp= new Emp();
            UpdateModel(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "id is required");
            }

            var data = db.emptable.Find(id);
            if (data == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Data not found");
            }
            db.emptable.Remove(data);   
            db.SaveChanges();
            return RedirectToAction("Index");
        }








    }
}