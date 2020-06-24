using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application
{
    //Zaduzeno za insert, update, delete
    public interface ICommend<Request> : IUseCase
    {
        void Execute(Request request);
    }

    //Zaduzeno za vracanje podataka npr. pretraga, filter, pronalazenje odredjenog 
    public interface IQuery<Search, Result> : IUseCase
    {
        Result Execute(Search search);
    }

    //Jedan vid sesije preko koje definisemo sta korisnik moze ili ne moze
    public interface IUseCase
    {
        public int Id { get; }

        public string Name { get; }
    }
}
