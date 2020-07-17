using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Meat : Food
    {
        private int quantity;
        public override int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
            }
        }
    }
}