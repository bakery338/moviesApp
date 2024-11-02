using MovieApp.Application.Repositry.Interfac;
using MovieSystem.Domain.Entites.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastrcuter.persstens.Repositery
{
    public class UnitOfWork:IunitOfwork
    {
        private readonly ApplicationContext _contex;
        private readonly ImovieRepostery _movies;
        private readonly IUserRepositery _users;

        public UnitOfWork(ApplicationContext contex)
        {
            _contex = contex;
        }

        public ImovieRepostery movies => _movies??  new MovieRepositery(_contex);

        public IUserRepositery users => _users ?? new UserRepositery(_contex);
    }
}
