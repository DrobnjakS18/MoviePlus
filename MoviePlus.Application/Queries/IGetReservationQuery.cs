using MoviePlus.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Queries
{
    public interface IGetReservationQuery : IQuery<int, ReservationDto>
    {
    }
}
