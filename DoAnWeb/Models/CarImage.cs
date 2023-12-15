using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public partial class CarImage
    {
        [Key]
        public int ImagesId { get; set; }
        public int? CarId { get; set; }
        public string? ImageUrl { get; set; }

        public virtual Car? Car { get; set; }
    }
}
