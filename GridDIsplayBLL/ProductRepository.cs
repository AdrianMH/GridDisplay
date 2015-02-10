using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GridDIsplayBLL
{
    public class ProductRepository : IProductRepository
    {
        readonly private GridDisplayEntities _dbContext;

        public ProductRepository()
        {
            this._dbContext=new GridDisplayEntities();
        }

        public List<Product> GetProducts(string search)
        {
            return _dbContext.Product.ToList();
        }
    }
}
