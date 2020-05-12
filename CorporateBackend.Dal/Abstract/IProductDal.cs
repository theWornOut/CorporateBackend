using CorporateBackend.Core.DataAccess;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}