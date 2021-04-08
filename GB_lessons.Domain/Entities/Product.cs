using GB_lessons.Domain.Entities.Base;
using GB_lessons.Domain.Entities.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace GB_lessons.Domain.Entities
{
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int SectionId { get; set; }

        [ForeignKey(nameof(SectionId))]
        public Section Section { get; set; }

        public int? BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public Section Brand { get; set; }

        public string ImageUrl { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }

    
}
