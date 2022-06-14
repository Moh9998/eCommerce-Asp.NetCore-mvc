using ETickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace ETickets.Models
{
    public class Movie
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Discription
        {
            get; set;
        }
        public double Price
        {
            get; set;
        }
        public DateTime StartDate
        {
            get; set;
        }
        public DateTime EndDate
        {
            get; set;
        }
        public MovieCtegory movieCtegory
        {
            get;
            set;
        }
        //RelationShips

        public List<Actor_Movie> Actors_Movies 
        {
            get; set;
        }
        //Cenima
        public int cenimaId { get; set; }
        [ForeignKey("cenimaId")]
        public Cenima cenima { get; set; }
        //Producer
        public int ProducreId { get; set; }
        [ForeignKey("ProducreId")]
        public Producre Producre { get; set; }

    }
}
