using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


/*Using necesarios*/
using VideoParte1.Context;
using VideoParte1.Models;
using System.Net;//Para mensajes de error

namespace VideoParte1.Controllers
{
    public class ProductoController : Controller
    {

        private DataBaseContext db = new DataBaseContext();

        //
        // GET: /Producto/
        public ActionResult Index()
        {
            return View(db.Productos.ToList());
        }

        //
        // GET: /Producto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Producto producto = db.Productos.Find(id);

            if (producto == null)
            {
                return HttpNotFound();
            }

            return View(producto);
        }

        //
        // GET: /Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Producto/Create
        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Productos.Add(producto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(producto);

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Producto/Edit/5
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Producto producto = db.Productos.Find(id);

            if (producto == null)
            {
                return HttpNotFound();
            }

            return View(producto);
        }

        //
        // POST: /Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Producto producto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(producto);

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Producto/Delete/5
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Producto producto = db.Productos.Find(id);

            if (producto == null)
            {
                return HttpNotFound();
            }

            return View(producto);
        }

        //
        // POST: /Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Producto prod)
        {
            try
            {
                Producto producto = new Producto();
                if (ModelState.IsValid)
                {
                    if (id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }

                    producto = db.Productos.Find(id);

                    if (producto == null)
                    {
                        return HttpNotFound();
                    }

                    db.Productos.Remove(producto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(producto);
            }
            catch
            {
                return View();
            }
        }
    }
}
