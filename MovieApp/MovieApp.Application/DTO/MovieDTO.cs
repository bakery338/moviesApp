using MovieSystem.Domain.Entites.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.DTO
{
    public class MovieDTO
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Imag { get; set; }
        public string? Vedio { get; set; }
        public bool? IsFree { get; set; }

        //navigeation properties
        public int Catogeryid { get; set; }
        public Catogery? Catogery { get; set; }

        public ICollection<Review>? reviews { get; set; }
    }


    public class MovieDetailDTO
    {

    }

}
