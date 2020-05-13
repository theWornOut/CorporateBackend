using CorporateBackend.Core.Entities;

namespace CorporateBackend.Entity.Concrete
{
    public class Category : IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
    }
}