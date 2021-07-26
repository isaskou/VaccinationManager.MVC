using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationManager.MVC.Models.ListCenter;
using VaccinationManager.MVC.Services;

namespace VaccinationManager.MVC.Controllers
{
    public class VaccinationCenterController : Controller
    {
        private readonly CenterServices _service;

        public VaccinationCenterController(CenterServices service)
        {
            _service = service;
        }

        // GET: VaccinationCenterController
        public ActionResult Index()
        {
            IEnumerable<CenterModel> models = _service.GetAll();
            return View(models);
        }

        // GET: VaccinationCenterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VaccinationCenterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VaccinationCenterController/Create
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

        // GET: VaccinationCenterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VaccinationCenterController/Edit/5
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

        // GET: VaccinationCenterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VaccinationCenterController/Delete/5
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
