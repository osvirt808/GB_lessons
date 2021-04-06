using GB_lessons.Domain.Entities.Interfaces;

namespace GB_lessons.Domain.Entities.Base
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        public string Name {get;set;}
    }
}
