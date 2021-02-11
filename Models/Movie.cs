using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPageMovieDataManager.Models
{

    public class Movie
    {
        //Used in the DB for primary key
        public int ID { get; set; }
        public string Title { get; set; }

        //The[DataType] attribute specifies the type of the data(Date). With this attribute:
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
