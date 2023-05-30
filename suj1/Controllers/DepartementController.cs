using Microsoft.AspNetCore.Mvc;
using suj1.Models;
using suj1.Repositories;

namespace suj1.Controllers
{
    public class DepartementController : Controller
    {
        private readonly IDepartementRepository departementRepository;

        public DepartementController(IDepartementRepository departementRepository)
        {
            this.departementRepository = departementRepository;
        }

        public IActionResult Index()
        {
            var departements = departementRepository.GetAll();
            return View(departements);
        }

        public IActionResult Details(int id)
        {
            var departement = departementRepository.GetById(id);
            if (departement == null)
                return NotFound();

            return View(departement);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Departement departement)
        {
            if (ModelState.IsValid)
            {
                departementRepository.Add(departement);
                return RedirectToAction("Index");
            }

            return View(departement);
        }

        public IActionResult Edit(int id)
        {
            var departement = departementRepository.GetById(id);
            if (departement == null)
                return NotFound();

            return View(departement);
        }

        [HttpPost]
        public IActionResult Edit(Departement departement)
        {
            if (ModelState.IsValid)
            {
                departementRepository.Edit(departement);
                return RedirectToAction("Index");
            }

            return View(departement);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var departement = departementRepository.GetById(id);
            if (departement == null)
                return NotFound();

            departementRepository.Delete(departement);
            return RedirectToAction("Index");
        }
    }
}
