using System;

namespace Salon.Service.DTOs
{
    public class WorkTaskDTO
    {
        public DateTime DateInitial { get; set; }
        public DateTime DateEnd { get; set; }
        public int IdClient { get; set; }
        public int IdService { get; set; }
        public int IdUser { get; set; }
        public decimal Price { get; set; }
        public string Observation { get; set; }
    }
}
