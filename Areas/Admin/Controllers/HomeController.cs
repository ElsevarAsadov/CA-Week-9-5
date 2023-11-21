using Microsoft.AspNetCore.Mvc;
using WebApplication2.DbContexts;

namespace WebApplication2.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    private readonly AppDbContext _dbContext;
    
    public HomeController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
    }
}