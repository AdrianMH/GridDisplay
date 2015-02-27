using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using GridDislpayEntities;
using GridDIsplayBLL;


namespace GridDisplayService
{
    public class GridDisplay : IGridDisplay
    {
        private IProductRepository productRepository;

        public GridDisplay()
        {
            productRepository = new ProductRepository();
        }
        public List<GridRow> GetProducts(string filter)
        {
            var products = productRepository.GetProducts(filter);

            List<GridRow> rows = new List<GridRow>();

            foreach (var product in products)
            {
                GridRow row = new GridRow();
            
                row.ProductId = product.ProductId;
                row.ProductName = product.Name;
                row.Price = product.Price;
                row.CategoryName = string.Join(",", product.Categories.Select(x => x.Name));
                row.Archived = product.Archived;

                rows.Add(row);
            }
            return rows;
        }
        
        public void Archive(int productId)
        {
            productRepository.Archive(productId);
        }
        
        public void Create(ProductDto productDto)
        {
            Product product = new Product();
            product.Name = productDto.Name;
            product.Price = productDto.Price;

            foreach (int category in productDto.Categories)
            {
                product.Categories.Add(productRepository.GetCategory(category));
            }

            productRepository.Create(product);
        }
        
        public void Save(ProductDto productDto)
        {
            Product product = new Product();

            product.ProductId = productDto.Id;
            product.Name = productDto.Name;

            product.Price = productDto.Price;
            
            foreach (Category category in product.Categories)
            {
                productDto.Categories.Add(category.CategoryId);
            }
            
            productRepository.Save(product);
        }


        public ProductDto GetDetails(int id)
        {
            var product = productRepository.GetDetails(id);

            var productDto = new ProductDto();

            productDto.Id = product.ProductId;
            productDto.Name = product.Name;
            productDto.Price = product.Price;
            productDto.Archived = product.Archived;

            foreach (Category category in product.Categories)
            {
                productDto.Categories.Add(category.CategoryId);
            }
            return productDto;
        }
    }
}
