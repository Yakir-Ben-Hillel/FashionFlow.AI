using FashionFlow.API.Models.Configurations;
using FashionFlow.API.Models.Hierarchies;
using Microsoft.EntityFrameworkCore;

namespace FashionFlow.API.Contexts
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Color> Colors { get; set; }
        public DbSet<CustomTagType> CustomTagTypes { get; set; }
        public DbSet<CustomTag> CustomTags { get; set; }
        public DbSet<Fit1> Fits1 { get; set; }
        public DbSet<Fit2> Fits2 { get; set; }
        public DbSet<Audience> Audiences { get; set; }
        public DbSet<HierarchyProductType> HierarchyProductTypes { get; set; }
        public DbSet<HierarchyProgramma> HierarchyProgramma { get; set; }
        public DbSet<HierarchyCategory> HierarchyCategories { get; set; }
        public DbSet<PlpTag> PlpTags { get; set; }
        public DbSet<SiteRuler> SiteRulers { get; set; }
        public DbSet<UnitOfMeasurement> UnitsOfMeasurement { get; set; }

    }
}
