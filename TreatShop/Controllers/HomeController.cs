using TreatShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatShopContext _db;

    public HomeController(TreatShopContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index() 
    { 
      dynamic model = new ExpandoObject();
      model.Flavor = _db.Flavors.ToList();
      model.Treat = _db.Treats.ToList();
      return View(model); 
    }
  }
}