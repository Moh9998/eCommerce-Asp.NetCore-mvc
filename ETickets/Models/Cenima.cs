using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ETickets.Models
{
    public class Cenima
    {
        [Key]
        public int Id
        {
            get; set;
        }

        public string logo
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
        //RelationShips
        public List<Movie> Movies
        {
            get; set;
        }
    }
}
