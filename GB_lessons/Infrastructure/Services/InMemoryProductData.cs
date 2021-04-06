using GB_lessons.Data;
using GB_lessons.Domain.Entities;
using GB_lessons.Infrastructure.Services.Interfaces;
using System.Collections.Generic;

namespace GB_lessons.Infrastructure.Services
{
    public class InMemoryProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        public IEnumerable<Section> GetSections() => TestData.Sections;
    }
}
