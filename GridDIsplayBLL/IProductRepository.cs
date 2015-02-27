using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridDislpayEntities;

namespace GridDIsplayBLL
{
    public interface IProductRepository
    {
        List<Product> GetProducts(string filter);
        void Archive(int productId);
        void Create(Product product);
        List<Category> GetCategories(int id);
        Category GetCategory(int id);
        void Save(Product product);

        List<Category> GetCategories();
        Product GetDetails(int id);
    }
}
