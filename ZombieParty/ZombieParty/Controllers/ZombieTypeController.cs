using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;
using ZombieParty.ViewModels;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        private BaseDonnees _baseDonnees { get; set; }
        public ZombieTypeController(BaseDonnees baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }


        public IActionResult Index()
        {
            //this.ViewBag.MaListe = new List<ZombieType>()
            //{
            //    new ZombieType(){TypeName= "Virus", Id=1},
            //    new ZombieType(){TypeName= "Contact", Id=2}
            //};
            //this.ViewBag.MaListe = _baseDonnees.ZombieTypes.ToList(); // utilisation de vieModel

            List<ZombieType> zombieTypesList = _baseDonnees.ZombieTypes.ToList();
            return View(zombieTypesList);
        }

        //GET CREATE
        public IActionResult Create()
        {
            return View();
        }


        //POST
        [HttpPost]
        public IActionResult Create(Models.ZombieType zombieType)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] = $"{zombieType.TypeName} zombie type addes";
                // Ajouter à la BD
                _baseDonnees.ZombieTypes.Add(zombieType);
                return this.RedirectToAction("Index");

            }

            return this.View(zombieType);
        }

        // Ajout de l'action GET pour Details

        public IActionResult Details(int id)
        {
            ZombieTypeVM zombieTypeVM = new()
            {
                ZombieType = new(),
                ZombiesList = _baseDonnees.Zombies.Where(z => z.ZombieTypeId == id).ToList(),
                ZombiesCount = _baseDonnees.Zombies.Count(),
                PointsAverage = _baseDonnees.Zombies.Average(p => p.Point)

            };
            zombieTypeVM.ZombieType = _baseDonnees.ZombieTypes.FirstOrDefault(zt => zt.Id == id);
            return View(zombieTypeVM);
        }




    }
}
