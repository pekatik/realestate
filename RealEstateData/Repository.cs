using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RealEstateData
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EstateDbContext _dbContext;
        protected DbSet<T> Set;


        public Repository(IDbContextFactory dbContextFactory)
        {
            _dbContext = dbContextFactory.Context;
            Set = _dbContext.Set<T>();
        }


        public void Insert(T entity)
        {
            Set.Add(entity);
        }

        public void Delete(T entity)
        {
            Set.Remove(entity);
        }


        public void SaveAll(bool continueOnConflict = false)
        {
            _dbContext.SaveChanges();
        }

        #region Properties


        public IQueryable<T> Table => _dbContext.Set<T>();

        public IEnumerable<string> ExecuteQuery(string command)
        {
            var result = _dbContext.Database.ExecuteSqlCommand(command);
            return new List<string> { result.ToString() };
        }

        #endregion
    }
}
