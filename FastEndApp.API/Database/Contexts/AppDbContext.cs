using FastEndApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastEndApp.API.Database.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
