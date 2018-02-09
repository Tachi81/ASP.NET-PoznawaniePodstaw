using PoznawaniePodstaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoznawaniePodstaw.Controllers
{
    public class PaczunioController : Controller
    {
        // GET: Paczunio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Paczunio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paczunio/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Paczunio/Create
        [HttpPost]
        public ActionResult Create(Paczunio model)
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

        // GET: Paczunio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paczunio/Edit/5
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

        // GET: Paczunio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paczunio/Delete/5
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
