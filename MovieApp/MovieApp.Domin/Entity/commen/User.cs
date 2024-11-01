using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    [Table("Users")]

    public class User
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }

        public  string? Email { get; set; }

        public  string? Password { get; set; }

        public short? Age { get; set; }
      
        public string? Type { get; set; }

        public ICollection<RoleUser>? RoleUsers { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Like>? Likes { get; set; }
       

    }
}
