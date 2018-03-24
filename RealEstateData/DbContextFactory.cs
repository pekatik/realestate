using System;

namespace RealEstateData
{
    public class DbContextFactory : IDbContextFactory, IDisposable
    {
        private readonly Lazy<EstateDbContext> _context = new Lazy<EstateDbContext>(() => new EstateDbContext());

        public EstateDbContext Context
        {
            get { return _context.Value; }
        }

        public void Dispose()
        {
            if (_context.IsValueCreated)
                Context.Dispose();
        }
    }
}
