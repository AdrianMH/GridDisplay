using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GridDislpayEntities
{
    [DataContract]
    public class ProductDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public bool Archived { get; set; }
        [DataMember]
        public List<int> Categories { get; set; }

        public ProductDto()
        {
            Categories = new List<int>();
        }
    }
}
