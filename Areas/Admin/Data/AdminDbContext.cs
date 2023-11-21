using Microsoft.EntityFrameworkCore;
using WebApplication2.Areas.Admin.Models;

namespace WebApplication2.DbContexts;

public class AdminDbContext : DbContext
{
    public DbSet<Feature> Features{ get; set; }
    
    
    public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
    {
    }
}