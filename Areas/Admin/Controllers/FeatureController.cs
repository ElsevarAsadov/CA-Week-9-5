using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Areas.Admin.Models;
using WebApplication2.DbContexts;

namespace WebApplication2.Areas.Admin.Controllers;

[Area("Admin")]
public class FeatureController : Controller
{
    private readonly AdminDbContext _dbContext;
    
    public FeatureController(AdminDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        ViewData["Title"] = "Dashboard";
        return View(_dbContext.Features.ToList());
    }

    [HttpGet]
    public IActionResult Index(int id)
    {
        Feature? f = _dbContext.Features.FirstOrDefault(x => x.Id == id);
        if (f != null)
        {
            return View((string) "Get", f);
            
        }

        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        ViewData["Title"] = "Create Feature";
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Feature feature)
    {
        if (ModelState.IsValid)
        {
            _dbContext.Features.Add(feature);
            _dbContext.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        Feature? f = _dbContext.Features.FirstOrDefault(x => x.Id == id);
        if (f != null) ;
        {
            _dbContext.Features.Remove(f);
            _dbContext.SaveChanges();
        }

        return RedirectToAction("Index");
    }


}