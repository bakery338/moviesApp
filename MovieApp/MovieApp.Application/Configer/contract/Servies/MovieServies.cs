using MovieApp.Application.Configer.contract.Interfac;
using MovieApp.Application.DTO;
using MovieApp.Application.Repositry.Interfac;
using MovieSystem.Domain.Entites.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Configer.contract.Servies
{
    public class MovieServies:ImoveServies
    {
        private readonly ImovieRepostery _repostery;

        private readonly IunitOfwork _unit;

        public MovieServies(ImovieRepostery repostery , IunitOfwork unit)
        {
            _repostery = repostery;
            _unit=unit;
        }

        //======================

        public Task<IEnumerable<MovieDTO>> GetAllMovie()
        {
            
            throw new NotImplementedException();
        }

        public Task<MovieDetailDTO> GetMovieByid()
        {
            throw new NotImplementedException();
        }
        public Task<Movie> CreateMovie(MovieDTO movieDto)
        {
            //busines
            //repositery
            //automaper
            //var result=_repostery.createmovie(automaper)
            //automaper

            throw new NotImplementedException();
        }

        public Task DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

       

        public Task<Movie> UpdateMovie(int id, MovieupdateDTO movieDto)
        {
            throw new NotImplementedException();
        }
    }
}
