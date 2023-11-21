using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.DbContexts;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AdminDbContext _dbContext;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [ActivatorUtilitiesConstructor]
    public HomeController(AdminDbContext context)
    {
        _dbContext = context;
    }    

    public IActionResult Index()
    {
        return View(_dbContext.Features.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}