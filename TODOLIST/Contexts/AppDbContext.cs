using Microsoft.EntityFrameworkCore;
using TODOLIST.Models;

namespace TODOLIST.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<TODOLIST.Models.Todo>Todos { get; set; }

}
