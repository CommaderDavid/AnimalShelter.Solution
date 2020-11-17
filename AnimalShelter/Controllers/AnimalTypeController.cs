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
      List<AnimalType> model = _db.Types.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(AnimalType type)
    {
      _db.Types.Add(type);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      AnimalType thisType = _db.Types.FirstOrDefault(type => type.ItemId == id);
      return View(thisType);
    }
  }
}