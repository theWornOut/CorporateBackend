using CorporateBackend.Core.DataAccess.NHibernate;
using CorporateBackend.Dal.Abstract;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Concrete.NHibernate
{
    public class NhCategoryDal : NhEntityRepositoryBase<Category>, ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}