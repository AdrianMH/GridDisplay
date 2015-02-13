using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using GridDIsplayBLL;
using GridDisplayService.Contracts;


namespace GridDisplayService
{
    public class GridDisplay : IGridDisplay
    {
        private IProductRepository productRepository;

        public GridDisplay()
        {
            productRepository = new ProductRepository();
        }
        public List<GridRow> GetProducts(string search)
        {
            var products = productRepository.GetProducts(search);

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
        
        public void Create(GridRow product)
        {
            productRepository.Create(product);
        }


    }
}
