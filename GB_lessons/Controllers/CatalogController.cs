using GB_lessons.Domain;
using GB_lessons.Infrastructure.Services.Interfaces;
using GB_lessons.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GB_lessons.Controllers
{
    public class CatalogController:Controller
    {
        private readonly IProductData _ProductData;

        public CatalogController(IProductData productData) => _ProductData = productData;

        public IActionResult Index(int? BrandId, int? SectionId)
        {
            var filter = new ProductFilter
            {
                BrandId = BrandId,
                SectionId = SectionId,
            };

            var products = _ProductData.GetProducts(filter);

            return View(new CatalogViewModel
            { 
                SectionId = SectionId,
                BrandId = BrandId,
                Products = products
                    .OrderBy(p => p.Order)
                    .Select(p => new ProductViewModel 
                    { 
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        ImageUrl = p.ImageUrl
                    })
            });

            
        }
    }
}
