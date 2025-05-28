using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace RazorSql;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Plantas> Plantas { get; set; }
}
