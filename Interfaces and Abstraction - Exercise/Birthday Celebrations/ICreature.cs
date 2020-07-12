using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface ICreature
    {
        string Name { get;  }
        string Birthday { get; }

        void HaveBirthday(string year);
    }
}
