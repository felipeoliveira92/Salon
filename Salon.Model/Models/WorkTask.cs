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
        public int IdClient { get; set; }

        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }        
        public int IdService { get; set; }

        [ForeignKey("IdService")]
        public virtual Services Service { get; set; }        
        public int IdUser { get; set; }
        
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
        public decimal Price { get; set; }
        public string Observation { get; set; }
    }
}