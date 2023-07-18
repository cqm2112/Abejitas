using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abejitas.Controllers
{
    public class Actions : Controller
    {
        // GET: Actions
        public ActionResult Index()
        {
            return View();
        }

        // GET: Actions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Actions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Actions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Actions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Actions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
