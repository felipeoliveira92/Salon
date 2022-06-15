namespace Salon.Model
{
    public class Services
    {
        [key]
        public int IdService { get; set; }
        public string NameService { get; set; }
        public string DescriptionService { get; set; }
        public decimal PriceService { get; set; }
    }
}