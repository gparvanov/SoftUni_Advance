using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IPrivate
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        decimal Salary { get; }
    }
}