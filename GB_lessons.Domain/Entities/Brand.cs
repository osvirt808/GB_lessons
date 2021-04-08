using GB_lessons.Domain.Entities.Base;
using GB_lessons.Domain.Entities.Interfaces;
using System.Collections.Generic;

namespace GB_lessons.Domain.Entities
{
    public class Brand: NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
