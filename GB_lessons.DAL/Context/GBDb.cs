using GB_lessons.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_lessons.DAL.Context
{
    public class GBDb: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Section> Sectinons { get; set; }

        public GBDb(DbContextOptions<GBDb> options) : base(options)
        {

        }

    }
}
