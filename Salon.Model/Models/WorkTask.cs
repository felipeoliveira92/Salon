using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Model.Models
{
    public class WorkTask
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateInitial { get; set; }
        public DateTime DateEnd { get; set; }

        [ForeignKey("Client")]
        public int IdClient { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("Service")]
        public int IdService { get; set; }
        public virtual Services Service { get; set; }

        [ForeignKey("User")]
        public int IdUser { get; set; }
        public virtual User User { get; set; }

        public decimal Price { get; set; }
        public string Observation { get; set; }
    }
}