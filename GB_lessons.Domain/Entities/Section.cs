using GB_lessons.Domain.Entities.Base;
using GB_lessons.Domain.Entities.Interfaces;

namespace GB_lessons.Domain.Entities
{
    public class Section: NamedEntity, IOrderedEntity
    {
        public int Order{ get; set; }

        public int? ParentId { get; set; }
    }
}
