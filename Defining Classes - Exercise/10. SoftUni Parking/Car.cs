using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        private string registrationNumber;
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public Car(string make,string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {                        
            string toReturn = 
                @$"Make: {this.Make}
Model: {this.Model}
HorsePower: {this.HorsePower}
RegistrationNumber: {this.RegistrationNumber}";
            return toReturn;
        }
    }

    public class Parking
    {
        List<Car> Cars = new List<Car>();        

        protected int capacity;

        protected int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Parking(int capacity)
        {
            this.Capacity = capacity;
            Cars = new List<Car>();
        }
        private int count;

        public int Count
        {
            get { return Cars.Count; }            
        }
        public string AddCar(Car Car)
        {
            foreach (var currentCar in Cars)
            {
                if(currentCar.RegistrationNumber == Car.RegistrationNumber)
                {
                    return "Car with that registration number, already exists!";
                }
            }
            if (Cars.Count == this.Capacity) return "Parking is full!";
            else
            {
                Cars.Add(Car);
                return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string RegistrationNumber)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if(Cars[i].RegistrationNumber == RegistrationNumber)
                {
                    Cars.RemoveAt(i);
                    return $"Successfully removed {RegistrationNumber}";
                }
            }
            return $"Car with that registration number, doesn't exist!";            
        }
        public string GetCar(string RegistrationNumber)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].RegistrationNumber == RegistrationNumber)
                {
                    return $"{Cars[i]}";
                }
            }
            return "Car with that registration number, doesn't exist!";
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            if (Cars.Count > 0 && RegistrationNumbers.Count>0)
            {
                foreach (var regNumber in RegistrationNumbers)
                {
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        if (Cars[i].RegistrationNumber == regNumber)
                        {
                            Cars.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }            
    }
}