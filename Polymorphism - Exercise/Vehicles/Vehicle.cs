using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface Vehicle
    {
        double FuelQuantity { get; }

        double FuelConsumption { get; }

        void Drive(double distance);

        void Refuel(double liters);
    }
}