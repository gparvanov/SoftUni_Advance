using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; set; }

        public Person(string firstname, string lastname, int age, decimal salary)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30) percentage /= 2;
            Salary *= ( 100 + percentage ) / 100;
        }
    }
}