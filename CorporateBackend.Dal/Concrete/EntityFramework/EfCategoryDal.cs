using CorporateBackend.Core.DataAccess.EntityFramework;
using CorporateBackend.Dal.Abstract;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}