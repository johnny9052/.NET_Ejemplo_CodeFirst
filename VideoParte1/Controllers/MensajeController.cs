using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VideoParte1.Models;
using VideoParte1.Context;

namespace VideoParte1.Controllers
{
    public class MensajeController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: /Mensaje/
        public ActionResult Index()
        {

            ViewBag.variable1 = "Este es mi primer valor";
            ViewBag.variable2 = "Este es mi segundo valor";
            ViewData["variable3"] = "Este es mi tercer valor";
            ViewData["variable4"] = "Este es mi cuarto valor";


            Mensaje mensaje = new Mensaje();
            mensaje.contenido="Hola como estas?";

            ViewData["msj"] = mensaje;

            return View(db.Mensajes.ToList());
        }

        // GET: /Mensaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mensaje mensaje = db.Mensajes.Find(id);
            if (mensaje == null)
            {
                return HttpNotFound();
            }
            return View(mensaje);
        }

        // GET: /Mensaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Mensaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,contenido")] Mensaje mensaje)
        {
            if (ModelState.IsValid)
            {
                db.Mensajes.Add(mensaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mensaje);
        }

        // GET: /Mensaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mensaje mensaje = db.Mensajes.Find(id);
            if (mensaje == null)
            {
                return HttpNotFound();
            }
            return View(mensaje);
        }

        // POST: /Mensaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,contenido")] Mensaje mensaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mensaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mensaje);
        }

        // GET: /Mensaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mensaje mensaje = db.Mensajes.Find(id);
            if (mensaje == null)
            {
                return HttpNotFound();
            }
            return View(mensaje);
        }

        // POST: /Mensaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mensaje mensaje = db.Mensajes.Find(id);
            db.Mensajes.Remove(mensaje);
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
