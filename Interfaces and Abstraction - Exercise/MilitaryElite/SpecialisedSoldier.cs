using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private , ISpecialisedSoldier
    {
        private string corps;
        public string Corps 
        {
            get => corps;
            set
            {                
                corps = value;
            }
        }
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) : base ( id, firstName, lastName, salary)
        {
            this.Corps = corps; 
        }        
    }
}