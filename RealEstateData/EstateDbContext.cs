using System.Data.Entity;

namespace RealEstateData
{
    public class EstateDbContext : DbContext
    {
        public DbSet<Estate> Estate { get; set; }
    }
}