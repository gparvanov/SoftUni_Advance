using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Dial(string number)
        {
            return $"Dialing... {number}";
        }

        public StationaryPhone()
        {

        }
    }
}
