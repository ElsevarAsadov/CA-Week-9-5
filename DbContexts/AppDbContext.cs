using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DbContexts;

public class AppDbContext : DbContext
{
    private DbSet<WebsiteFeaturesModel> WebsiteFeatures { get; set; }
    
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}