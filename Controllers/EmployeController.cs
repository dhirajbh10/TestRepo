using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HippoAPIAssignment.Controllers
{
    public class EmployeController : Controller
    {
        // GET: EmployeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmployeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeController/Create
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

        // GET: EmployeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeController/Edit/5
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

        // GET: EmployeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeController/Delete/5
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
