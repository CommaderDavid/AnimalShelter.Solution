using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class AnimalTypesController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalTypesController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<AnimalType> model = _db.AnimalTypes.OrderBy(animal => animal.TypeSpecies).OrderBy(animal => animal.DateOfAdmittance).ToList();
      // Gives order to list by using OrderBy() then ordered by what, (TypeSpecies)
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(AnimalType type)
    {
      _db.AnimalTypes.Add(type);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      AnimalType thisType = _db.AnimalTypes.FirstOrDefault(type => type.AnimalTypeId == id);
      return View(thisType);
    }
  }
}