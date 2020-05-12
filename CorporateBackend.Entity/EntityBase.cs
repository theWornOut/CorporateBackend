using System;
using CorporateBackend.Core.Entities;

namespace CorporateBackend.Entity
{
    public class EntityBase : IEntity
    {
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}