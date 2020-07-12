using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISpecialisedSoldier
    { 
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string Corps { get; }
    }
}