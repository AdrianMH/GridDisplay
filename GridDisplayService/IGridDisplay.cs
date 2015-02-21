using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GridDislpayEntities;

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
        List<GridRow> GetDetails(int productId);
    }
}
