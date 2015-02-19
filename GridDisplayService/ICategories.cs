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
    public interface ICategories
    {
        //[OperationContract]
        //List<CategoryDto> GetCategories(int id);

        [OperationContract]
        List<CategoryDto> GetCategories();
    }
}
