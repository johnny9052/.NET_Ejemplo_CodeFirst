using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*Using necesarios*/
using VideoParte1.Context;
using VideoParte1.Models;

namespace VideoParte1.Controllers
{
    public class EmpleadoController : Controller
    {

        private DataBaseContext db = new DataBaseContext();

        //
        // GET: /Empleado/
        public ActionResult Index()
        {
            return View(db.Empleados.ToList());

        }

        //
        // GET: /Empleado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Empleado/Create
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Empleados.Add(empleado);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(empleado);

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Empleado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Empleado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
