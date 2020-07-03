using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle(200,1.5);

            myVehicle.Drive(1);
            Console.WriteLine($"HP:{myVehicle.HorsePower} + Fuel:{myVehicle.Fuel:F2}L");



            Motorcycle myMotor = new Motorcycle(150, 20);

            myMotor.Drive(5);
            Console.WriteLine($"HP:{myMotor.HorsePower} + Fuel:{myMotor.Fuel:F2}L");

            Car myCar = new Car(250, 55.6);

            myCar.Drive(15);
            Console.WriteLine($"HP:{myCar.HorsePower} + Fuel:{myCar.Fuel:F2}L");

            FamilyCar myFamilyCar = new FamilyCar(250, 55.6);

            myFamilyCar.Drive(15);
            Console.WriteLine($"HP:{myFamilyCar.HorsePower} + Fuel:{myFamilyCar.Fuel:F2}L");

        }
    }
}