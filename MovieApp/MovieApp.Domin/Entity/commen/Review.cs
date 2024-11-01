using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class Review
    {
        public int Id { get; set; }
        public  string?  Content { get; set; }
        public string? date { get; set; }
        public string? Rate { get; set; }
        public bool? IsHaid { get; set; }

        //navigation property user to review
        public int Userid { get; set; }
        public User? User { get; set; }

        //navigation property movie to review
        public int Movieid { get; set; }
        public Movie? Movie { get; set; }

        public ICollection<Like> Likes { get; set; } 


    }
}
