using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private string[] startDate;

        public  string[] StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private string[] endDate;

        public string[] EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int ComputeTimeSpanInDays(string[] start, string[] end)
        {
            DateTime startDate = new DateTime(int.Parse(start[0]), int.Parse(start[1]), int.Parse(start[2]));
            DateTime endDate = new DateTime(int.Parse(end[0]), int.Parse(end[1]), int.Parse(end[2]));

            TimeSpan days = endDate - startDate;

            return (int)days.TotalDays;
        }
    }
}