using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
    {
    public enum Brand { CammelPak, Yeti, H20Blaster}

    public enum VehicleType {Car,Truck,SUV,StationWagon,Motorcycle,ATV,Spaceship,Boar,HorseAndBuggy}
    public class Vehicle
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Mileage { get; set; }
        public ValueType TypeOfVehicle { get; set; }

        //Constructor
        public Vehicle() { }
        public Vehicle(string make, string model, decimal mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName 
        {
            get { return $"{FirstName} {LastName}"; }  
        }

        public DateTime DOB { get; set; }

        public int Age
        {
            get
            {
                if(DOB == new DateTime())
                {
                    return 9001;
                }
                TimeSpan ageSpan = DateTime.Now - DOB;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }

        public bool IsAdult
        {
            get
            {
                if(Age >= 21)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Person() { }
        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
        }
    }

    public class WaterBottle
    {
        public decimal Volume { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public Brand BrandName { get; set; }

        public WaterBottle() { }
    }

    public class Candy
    {
        private int empty = 0;
        public string Color{ get; set; }
        public int Quantity { get; set; }
        public string Taste { get; set; }
        public bool IndviduallyWrapped { get; set; }
        private string NeedMoreCandy 
        {
            get
            {
                if(Quantity > empty)
                {
                    return "You still have sugar!";
                }
                else
                {
                    return "Get to the store";
                }
            }
        }
    }
}
