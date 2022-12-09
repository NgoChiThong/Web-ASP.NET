using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnDotNetWeb.Areas.Admin.Controllers
{
    public class QLKHController : Controller
    {
        // GET: Admin/QLKH
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/QLKH/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/QLKH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QLKH/Create
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

        // GET: Admin/QLKH/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/QLKH/Edit/5
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

        // GET: Admin/QLKH/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/QLKH/Delete/5
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
