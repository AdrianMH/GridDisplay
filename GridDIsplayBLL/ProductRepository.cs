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
            var xx = from pc in _dbContext.Products
                     from p in pc.Categories
                    
                    select p;
            
            return _dbContext.Products.ToList();
        }


        public bool Archive(int productId)
        {
            Product product = _dbContext.Products.Find(productId);
            product.Archived = true;
            _dbContext.SaveChanges();
            return true;
        }
    }
}
