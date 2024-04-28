using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infastracted;

public class ApplicationDbContext: DbContext
{
    public DbSet<ProjectCard> Vacancies { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}