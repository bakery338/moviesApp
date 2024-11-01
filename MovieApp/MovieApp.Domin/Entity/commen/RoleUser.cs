using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class RoleUser
    {
        public int Userid { get; set; }
        [ForeignKey("Userid")]
        public User? User { get; set; }

        public int Roleid { get; set; }
        [ForeignKey("Roleid")]
        public Role? Role { get; set; }

        public bool IsActive { get; set; }

       

       
    }
}
