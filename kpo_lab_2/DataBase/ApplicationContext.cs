using kpo_lab_2.Database.Models;
using kpo_lab_2.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace kpo_lab_2.DataBase;

public class ApplicationContext : DbContext
{
    public DbSet<Album> Albums { get; set; }
    public DbSet<Performer> Performers { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<User> Users { get; set; }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
}