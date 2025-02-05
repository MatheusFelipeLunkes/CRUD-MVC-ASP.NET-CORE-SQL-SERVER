using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductModel
{
    [Table("product")]
    public class Product
    {
        [Column]
        public int Id { get; set; }
        [Column]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Column]
        [Required]
        [StringLength(300)]
        public string? Description { get; set; }
        [Column]
        public double? Price { get; set; }

       
    }

    

}
