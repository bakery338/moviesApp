using MovieApp.Application.DTO;
using MovieSystem.Domain.Entites.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Configer.contract.Interfac
{
    public interface ImoveServies
    {
        Task<IEnumerable<MovieDTO>> GetAllMovie();

        Task<MovieDetailDTO> GetMovieByid();

        Task<Movie> CreateMovie(MovieDTO movieDto);

        Task<Movie> UpdateMovie(int id, MovieupdateDTO movieDto);

        Task DeleteMovie(int id);
    }
}
