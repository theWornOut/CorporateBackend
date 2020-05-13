using System.Collections.Generic;
using CorporateBackend.Core.DataAccess;
using CorporateBackend.Entity.ComplexType;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}