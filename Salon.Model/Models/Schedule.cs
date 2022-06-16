namespace Salon.Model.Models
{
    public class Schedule
    {
        [key]
        public int IdAppointment { get; set; }
        public DateTime DateInitial { get; set; }
        public DateTime DateEnd { get; set; }
        public int IdService { get; set; }
        public int IdUser { get; set; }
        public decimal Price { get; set; }
        public string Observation { get; set; }
    }
}