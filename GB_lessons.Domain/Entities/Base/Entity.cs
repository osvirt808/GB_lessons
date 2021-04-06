using GB_lessons.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_lessons.Domain.Entities.Base
{
    public abstract class Entity: IEntity
    {
        public int Id { get; set; }

    }
}
