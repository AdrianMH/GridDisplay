using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GridDislpayEntities;
using GridDIsplayBLL;

namespace GridDisplayService
{
    [ServiceContract]
    public interface IGridDisplay
    {
        [OperationContract]
        List<GridRow> GetProducts(string filter);

        [OperationContract]
        void Archive(int productId);

        [OperationContract]
        void Create(ProductDto product);

        [OperationContract]
        ProductDto GetDetails(int id);

        [OperationContract]
        void Save(ProductDto product);
    }
}
