using System.Runtime.Serialization;

namespace GridDislpayEntities
{
    [DataContract]
    public class GridRow
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public bool Archived { get; set; }
    }
}
