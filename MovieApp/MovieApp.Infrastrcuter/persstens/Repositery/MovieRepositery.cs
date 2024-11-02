using MovieApp.Application.Repositry;
using MovieApp.Application.Repositry.Interfac;
using MovieSystem.Domain.Entites.ApplicationContext;
using MovieSystem.Domain.Entites.Commen;

namespace MovieApp.Infrastrcuter.persstens.Repositery
{
    public class MovieRepositery : Repositery<Movie>,ImovieRepostery
    {


        public MovieRepositery(ApplicationContext context):base(context) 
        {
            
        }




    }
}
