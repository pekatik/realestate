using System.Collections.Generic;
using System.Linq;

namespace RealEstateData
{

    public interface IRepository<T> where T : class
    {
        void Insert(T entity);

        void Delete(T entity);

        void SaveAll(bool continueOnConflict = false);

        IQueryable<T> Table { get; }

        IEnumerable<string> ExecuteQuery(string command);
    }
}
