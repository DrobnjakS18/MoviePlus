using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application
{
    public interface IApplicationUser
    {
        int id { get; }
        //definise na koji nacin identifikujemo usera npr. token , sesija ...
        string Identity { get; }
        //Lista svih Id Implementacija kojima koristnik ima pristup
        IEnumerable<int> AllowedUseCases { get; } //[1,2,3...]
    }
}
