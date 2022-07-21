using Salon.Model.Models;
using System;

namespace Salon.Service.DTOs
{
    public class InsertWorkTaskDTO
    {
        public DateTime DateInitial { get; set; }
        public DateTime DateEnd { get; set; }
        public int IdService { get; set; }
        public Services Service { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public decimal Price { get; set; }
        public string Observation { get; set; }
    }
}
