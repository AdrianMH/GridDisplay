using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GridDisplayService.Contracts;

namespace GridDisplayService
{
    [ServiceContract]
    public interface IGridDisplay
    {
        [OperationContract]
        List<GridRow> GetProducts(string search);

        [OperationContract]
        bool Archive(int productId);
    }
}
