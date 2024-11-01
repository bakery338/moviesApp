using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class Permission
    {
        public int Id { get; set; }
        public string? Name { get; set; }
       public ICollection<RolePermission>? rolePermissions { get; set; }

    }
}
