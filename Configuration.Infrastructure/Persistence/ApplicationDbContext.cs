using Configuration.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Settings.Domain.Entities;

namespace Configuration.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new ConsumerSeedData());
        modelBuilder.Entity<Consumer>().Navigation(e => e.PlanType).AutoInclude();
        modelBuilder.Entity<Company>().Navigation(e => e.BusinessType).AutoInclude();
        modelBuilder.Entity<Company>().Navigation(e => e.Category).AutoInclude();
        modelBuilder.Entity<Department>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<Designation>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<Designation>().Navigation(e => e.Department).AutoInclude();
        modelBuilder.Entity<Role>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<Role>().Navigation(e => e.Department).AutoInclude();
        modelBuilder.Entity<Role>().Navigation(e => e.Designation).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.Address).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.Country).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.State).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.City).AutoInclude();
        modelBuilder.Entity<BusinessCategory>().Navigation(e => e.BusinessType).AutoInclude();
    }
    public DbSet<Consumer> Consumers { get; set; }
    public DbSet<PlanType> PlanTypes { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<BusinessCategory> BusinessCategories { get; set; }
    public DbSet<BusinessType> BusinessTypes { get; set; }
    public DbSet<BusinessLocation> BusinessLocations { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Client> clients { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Address> Addresses { get; set; }
}
