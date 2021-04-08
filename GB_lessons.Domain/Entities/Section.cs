﻿using GB_lessons.Domain.Entities.Base;
using GB_lessons.Domain.Entities.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GB_lessons.Domain.Entities
{
    public class Section: NamedEntity, IOrderedEntity
    {
        public int Order{ get; set; }

        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Section Parent { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
