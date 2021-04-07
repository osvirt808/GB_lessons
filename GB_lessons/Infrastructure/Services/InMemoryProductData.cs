using GB_lessons.Data;
using GB_lessons.Domain;
using GB_lessons.Domain.Entities;
using GB_lessons.Infrastructure.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GB_lessons.Infrastructure.Services
{
    public class InMemoryProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        public IEnumerable<Section> GetSections() => TestData.Sections;

         public IEnumerable<Product> GetProducts(ProductFilter Filter = null)
        {
            var query = TestData.Product;

            if (Filter?.SectionId is { } section_id)
                query = query.Where(Product => Product.SectionId == section_id);

            if(Filter?.BrandId is { } brand_id)
                query = query.Where(Product => Product.BrandId == brand_id);

            return query;
        }
    }
}
