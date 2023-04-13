using Learn1.Domain.Entities.Commons;

namespace Learn1.Domain.Entities.Products
{
    public class ProductImages:BaseEntity
    {
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }
        public string Src { get; set; }



    }
}
