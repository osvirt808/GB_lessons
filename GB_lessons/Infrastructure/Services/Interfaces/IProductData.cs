using GB_lessons.Domain;
using GB_lessons.Domain.Entities;
using System.Collections.Generic;

namespace GB_lessons.Infrastructure.Services.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter Filter = null);

    }
}
