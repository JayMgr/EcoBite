using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoBiteBook.Models
{
    public class Donation
    {
        [Key]
        public int DonationId { get; set; }
        [ForeignKey("Donor")]
        public int DonorId { get; set; }
        // public User Donor { get; set; }  // Linked to User model

        public ICollection<Fooditem> Fooditems { get; set; }  // One-to-Many relationship with FoodItem

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }  // Pending, Completed, etc.

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
    }
}
