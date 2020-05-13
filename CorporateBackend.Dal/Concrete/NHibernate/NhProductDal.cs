using CorporateBackend.Core.DataAccess.NHibernate;
using CorporateBackend.Dal.Abstract;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}