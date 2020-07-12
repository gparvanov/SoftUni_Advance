using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISpy
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        int CodeNumber { get; }
    }
}