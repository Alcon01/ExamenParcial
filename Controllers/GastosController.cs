using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamenParcial.Models;

namespace ExamenParcial.Controllers
{
    [Authorize]
    public class GastosController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: Gastos
        public ActionResult Index()
        {
            var gastosSet = db.GastosSet.Include(g => g.Categoria).Include(g => g.Moneda).Include(g => g.Lugar);
            return View(gastosSet.ToList());
        }

        // GET: Gastos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gastos gastos = db.GastosSet.Find(id);
            if (gastos == null)
            {
                return HttpNotFound();
            }
            return View(gastos);
        }

        // GET: Gastos/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(db.CategoriaSet, "Id", "Nombre");
            ViewBag.MonedaId = new SelectList(db.MonedaSet, "Id", "Nombre");
            ViewBag.LugarId = new SelectList(db.LugarSet, "Id", "Nombre");
            return View();
        }

        // POST: Gastos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fecha,Cantidad,CategoriaId,MonedaId,LugarId")] Gastos gastos)
        {
            if (ModelState.IsValid)
            {
                db.GastosSet.Add(gastos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.CategoriaSet, "Id", "Nombre", gastos.CategoriaId);
            ViewBag.MonedaId = new SelectList(db.MonedaSet, "Id", "Nombre", gastos.MonedaId);
            ViewBag.LugarId = new SelectList(db.LugarSet, "Id", "Nombre", gastos.LugarId);
            return View(gastos);
        }

        // GET: Gastos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gastos gastos = db.GastosSet.Find(id);
            if (gastos == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(db.CategoriaSet, "Id", "Nombre", gastos.CategoriaId);
            ViewBag.MonedaId = new SelectList(db.MonedaSet, "Id", "Nombre", gastos.MonedaId);
            ViewBag.LugarId = new SelectList(db.LugarSet, "Id", "Nombre", gastos.LugarId);
            return View(gastos);
        }

        // POST: Gastos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fecha,Cantidad,CategoriaId,MonedaId,LugarId")] Gastos gastos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gastos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.CategoriaSet, "Id", "Nombre", gastos.CategoriaId);
            ViewBag.MonedaId = new SelectList(db.MonedaSet, "Id", "Nombre", gastos.MonedaId);
            ViewBag.LugarId = new SelectList(db.LugarSet, "Id", "Nombre", gastos.LugarId);
            return View(gastos);
        }

        // GET: Gastos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gastos gastos = db.GastosSet.Find(id);
            if (gastos == null)
            {
                return HttpNotFound();
            }
            return View(gastos);
        }

        // POST: Gastos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gastos gastos = db.GastosSet.Find(id);
            db.GastosSet.Remove(gastos);
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
