using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practica2TN.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        // GET: Ejercicio1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ejercicio1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ejercicio1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ejercicio1Controller/Create
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

        // GET: Ejercicio1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ejercicio1Controller/Edit/5
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

        // GET: Ejercicio1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ejercicio1Controller/Delete/5
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
