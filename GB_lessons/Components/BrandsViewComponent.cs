using GB_lessons.Infrastructure.Services.Interfaces;
using GB_lessons.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GB_lessons.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductData _ProductData;

        public BrandsViewComponent(IProductData productData) =>_ProductData = productData;

        public IViewComponentResult Invoke() => View(GetBrands());

        public IEnumerable<BrandViewModel> GetBrands() =>
            _ProductData.GetBrands()
                .OrderBy(b => b.Order)
                .Select(b => new BrandViewModel
                {
                    Id = b.Id,
                    Name = b.Name                    
                });
    } 
}
