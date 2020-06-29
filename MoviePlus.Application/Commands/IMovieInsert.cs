using MoviePlus.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Commands
{
    public interface IMovieInsert : ICommend<MovieDto>
    {
    }
}
