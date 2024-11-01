using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class Like
    {
        public int Id { get; set; }
        public bool? IsLike { get; set; }

        //navagetion property like to user
        public int Userid {  get; set; }
         public User? User { get; set; }

        //navagetion property like to review
        public int Reviewid { get; set; }
        public Review? Review { get; set; }

       
       
    }
}
