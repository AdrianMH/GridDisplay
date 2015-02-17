using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridDIsplayBLL
{
    public interface IProductRepository
    {
        List<Product> GetProducts(string search);
        void Archive(int productId);
        void Create(Product product);
        void Details(int productId);
        List<Category> GetCategories(int id);
    }
}
