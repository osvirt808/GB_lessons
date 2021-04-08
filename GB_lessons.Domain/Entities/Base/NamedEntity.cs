using GB_lessons.Domain.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GB_lessons.Domain.Entities.Base
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
