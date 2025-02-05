using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_FRAMEWORK.Models;

namespace CRUD_FRAMEWORK.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
            return View(context.Libros.ToList());
            }

        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Libros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Libro libros)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                 context.Libros.Add(libros);
                 context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Libros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Libro libros)
        {
            try
            {
                using (DbModels context = new DbModels()) 
                
                {
                 context.Entry(libros).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Libros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels context = new DbModels()) 
                {
                 Libro libro = context.Libros.Where(x=>x.id == id).FirstOrDefault();
                 context.Libros.Remove(libro);
                 context.SaveChanges();


                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
