using Microsoft.AspNetCore.Mvc;
using suj1.Models;
using suj1.Repositories;

namespace suj1.Controllers
{
    public class EnseignantController : Controller
    {
        private readonly IEnseignantRepository enseignantRepository;

        public EnseignantController(IEnseignantRepository enseignantRepository)
        {
            this.enseignantRepository = enseignantRepository;
        }

        public IActionResult Index()
        {
            var enseignants = enseignantRepository.GetAll();
            return View(enseignants);
        }

        public IActionResult Details(int id)
        {
            var enseignant = enseignantRepository.GetById(id);
            if (enseignant == null)
                return NotFound();

            return View(enseignant);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Enseignant enseignant)
        {
            if (ModelState.IsValid)
            {
                enseignantRepository.Add(enseignant);
                return RedirectToAction("Index");
            }

            return View(enseignant);
        }

        public IActionResult Edit(int id)
        {
            var enseignant = enseignantRepository.GetById(id);
            if (enseignant == null)
                return NotFound();

            return View(enseignant);
        }

        [HttpPost]
        public IActionResult Edit(Enseignant enseignant)
        {
            if (ModelState.IsValid)
            {
                enseignantRepository.Edit(enseignant);
                return RedirectToAction("Index");
            }

            return View(enseignant);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var enseignant = enseignantRepository.GetById(id);
            if (enseignant == null)
                return NotFound();

            enseignantRepository.Delete(enseignant);
            return RedirectToAction("Index");
        }
    }
}
