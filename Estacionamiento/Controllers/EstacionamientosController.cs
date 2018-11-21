using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Estacionamiento.Models;

namespace Estacionamiento.Controllers
{
    public class EstacionamientosController : Controller
    {
        private EstacionamientosDB db = new EstacionamientosDB();

        // GET: Estacionamientos
        public ActionResult Index()
        {
            return View(db.Estacionamientos.ToList());
        }

        // GET: Estacionamientos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamientos estacionamientos = db.Estacionamientos.Find(id);
            if (estacionamientos == null)
            {
                return HttpNotFound();
            }
            return View(estacionamientos);
        }

        // GET: Estacionamientos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estacionamientos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstacionamientosID,Fecha,Nivel,Placas")] Estacionamientos estacionamientos)
        {
            if (ModelState.IsValid)
            {
                db.Estacionamientos.Add(estacionamientos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estacionamientos);
        }

        // GET: Estacionamientos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamientos estacionamientos = db.Estacionamientos.Find(id);
            if (estacionamientos == null)
            {
                return HttpNotFound();
            }
            return View(estacionamientos);
        }

        // POST: Estacionamientos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstacionamientosID,Fecha,Nivel,Placas")] Estacionamientos estacionamientos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estacionamientos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estacionamientos);
        }

        // GET: Estacionamientos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamientos estacionamientos = db.Estacionamientos.Find(id);
            if (estacionamientos == null)
            {
                return HttpNotFound();
            }
            return View(estacionamientos);
        }

        // POST: Estacionamientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estacionamientos estacionamientos = db.Estacionamientos.Find(id);
            db.Estacionamientos.Remove(estacionamientos);
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
