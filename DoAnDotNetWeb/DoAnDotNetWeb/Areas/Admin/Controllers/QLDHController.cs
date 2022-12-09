using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnDotNetWeb.Areas.Admin
{
    public class QLDHController : Controller
    {
        // GET: Admin/QLDH
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/QLDH/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/QLDH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QLDH/Create
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

        // GET: Admin/QLDH/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/QLDH/Edit/5
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

        // GET: Admin/QLDH/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/QLDH/Delete/5
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
