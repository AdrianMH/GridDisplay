using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridDislpayEntities;
using GridDIsplayBLL;

namespace GridDisplayService
{
    public class Categories : ICategories
    {
        private IProductRepository productRepository;

        public Categories()
        {
            productRepository = new ProductRepository();
        }

        public List<CategoryDto> GetCategories(int id)
        {
            var productCategories = productRepository.GetCategories(id);

            List<CategoryDto> categories = new List<CategoryDto>();

            foreach (var category in productCategories)
            {
                CategoryDto categoryDto = new CategoryDto();

                categoryDto.Name = category.Name;
                categoryDto.Id = category.CategoryId;

                categories.Add(categoryDto);
            }

            return categories;
        }


        public List<CategoryDto> GetCategories()
        {
            return productRepository.GetCategories().Select(item => new CategoryDto()
            {
                Name = item.Name,
                Id = item.CategoryId
            }).ToList();
        }
    }
}
