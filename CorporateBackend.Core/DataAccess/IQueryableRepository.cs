using System.Linq;
using CorporateBackend.Core.Entities;

namespace CorporateBackend.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}