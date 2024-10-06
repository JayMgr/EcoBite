using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcoBiteBook.Models
{
    public class Fooditem
    {
        [Key]
        public int FooditemId { get; set; }
        [DisplayName("Fooditem Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Expiration Date")]

        public string ExpirationDate { get; set; }

        // [Required]
        // public string Category { get; set; }

    }
}
