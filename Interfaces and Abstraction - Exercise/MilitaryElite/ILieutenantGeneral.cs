﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ILieutenantGeneral
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        decimal Salary { get; }
    }
}