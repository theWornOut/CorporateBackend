using System.Linq;
using System.Collections.Generic;
using CorporateBackend.Core.DataAccess.EntityFramework;
using CorporateBackend.Dal.Abstract;
using CorporateBackend.Entity.ComplexType;
using CorporateBackend.Entity.Concrete;

namespace CorporateBackend.Dal.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (var context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}