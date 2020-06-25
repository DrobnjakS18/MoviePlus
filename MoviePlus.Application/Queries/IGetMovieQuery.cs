using MoviePlus.Application.Dto;
using MoviePlus.Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Queries
{
    public interface IGetMovieQuery : IQuery<MovieSearch, PageResponse<MovieDto>>
    {
    }
}
