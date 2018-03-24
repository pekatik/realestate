namespace RealEstateData
{
    public interface IDbContextFactory
    {
        EstateDbContext Context { get; }
    }
}