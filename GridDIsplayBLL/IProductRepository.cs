using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridDIsplayBLL
{
    public interface IProductRepository
    {
        List<Product> GetProducts(string filter);
        void Archive(int productId);
        void Create(Product product);
        //void GetDetails(Product product);
        List<Category> GetCategories(int id);
        Category GetCategory(int id);
        void Edit(Product product);

        List<Category> GetCategories();
    }
}
