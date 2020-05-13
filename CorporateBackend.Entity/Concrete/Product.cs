using CorporateBackend.Core.Entities;

namespace CorporateBackend.Entity.Concrete
{
    public class Product : IEntity //EntityBase
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }
    }
}