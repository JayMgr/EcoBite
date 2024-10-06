using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBiteBook.Models
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryId { get; set; }

        //[Required]
        //[ForeignKey("FoodItemId")]
        //public int FoodItemId { get; set; }

        [Required]
        [Range (1, 100)]
        [DisplayName("Quantity in Stock")]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        //public FoodItem? FoodItem { get; set; }
    }
}
