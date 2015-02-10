using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            return productRepository.GetProducts(search).
                Select(product => new GridRow() 
                { ProductName = product.Name,
                    Price = product.Price,})
                .ToList();
        }
    }
}
