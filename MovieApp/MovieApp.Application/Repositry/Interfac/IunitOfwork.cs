using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Repositry.Interfac
{
    public interface IunitOfwork
    {
        ImovieRepostery movies { get; }
        IUserRepositery  users { get; }

    }
}
