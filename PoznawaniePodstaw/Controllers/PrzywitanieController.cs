using PoznawaniePodstaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoznawaniePodstaw.Controllers
{
    public class PrzywitanieController : Controller
    {
        // GET: Przywitanie
        public ActionResult Index()
        {
            ViewBag.info = (DateTime.Now.Hour > 17) ? "Dobry Wieczór" : "Dzień dobry";
            return View();
        }

        // GET: Przywitanie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Przywitanie/Create
        public ActionResult Create()
        {
            var testowy = new Testowa();
            testowy.Imie = "Maniek";
            return View(testowy);
        }

        // POST: Przywitanie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Przywitanie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Przywitanie/Edit/5
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

        // GET: Przywitanie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Przywitanie/Delete/5
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
