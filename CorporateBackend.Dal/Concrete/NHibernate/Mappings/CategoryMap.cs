using CorporateBackend.Entity.Concrete;
using FluentNHibernate.Mapping;

namespace CorporateBackend.Dal.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();

            Id(x => x.CategoryId).Column("CategoryId");
            Map(x => x.CategoryId).Column("CategoryId");
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}