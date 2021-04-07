using GB_lessons.Domain.Entities.Base;
using GB_lessons.Domain.Entities.Interfaces;

namespace GB_lessons.Domain.Entities
{
    public class Brand: NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
