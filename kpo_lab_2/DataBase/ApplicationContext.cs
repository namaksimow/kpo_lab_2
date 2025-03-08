using kpo_lab_2.Models;
using Microsoft.EntityFrameworkCore;

namespace kpo_lab_2;

public class ApplicationContext : DbContext
{
    public DbSet<Album> Albums { get; set; }
    public DbSet<Performer> Performers { get; set; }
    public DbSet<Song> Songs { get; set; }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
}