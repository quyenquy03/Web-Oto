using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public partial class OrderDetail
    {
        [Key]
        public int DetailsId { get; set; }
        public int? OrderId { get; set; }
        public int? CarId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Total { get; set; }

        public virtual Order? Order { get; set; }
    }
}
