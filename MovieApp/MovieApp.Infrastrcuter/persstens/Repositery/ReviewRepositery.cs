using MovieApp.Application.Repositry.Interfac;
using MovieSystem.Domain.Entites.ApplicationContext;
using MovieSystem.Domain.Entites.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastrcuter.persstens.Repositery
{
    public class ReviewRepositery:Repositery<Review>, IReviewRepositery
    {
        public ReviewRepositery(ApplicationContext context) : base(context)
        {

        }

    }
}
