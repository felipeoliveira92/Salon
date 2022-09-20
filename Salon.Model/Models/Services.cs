using System.ComponentModel.DataAnnotations;

namespace Salon.Model.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}