using CorporateBackend.Core.DataAccess.EntityFramework;
using CorporateBackend.Dal.Abstract;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,EfDbContext>, IProductDal
    {
    }
}