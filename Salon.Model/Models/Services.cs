using System.ComponentModel.DataAnnotations;

namespace Salon.Model.Models
{
    public class Services
    {
        [Key]
        public int IdService { get; set; }
        public string NameService { get; set; }
        public string DescriptionService { get; set; }
        public decimal PriceService { get; set; }
    }
}