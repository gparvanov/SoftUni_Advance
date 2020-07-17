using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public interface Vehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }
        void Drive(double distance);
        void Refuel(double liters);
    }
}