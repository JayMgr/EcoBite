using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcoBiteWeb.Models
{
    public class Fooditem
    {
        [Key]
        public int FooditemId { get; set; }
        [DisplayName("Fooditem Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Expiration Date")]
        public string ExpirationDate { get; set; }
        
    }
}
