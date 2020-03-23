using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public int AddTwoNumbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public double AddTwoNumbers(double x, double y)
        {
            double sum = x + y;
            return sum;
        }

        private int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Seth");
            SayHello("Pickle Rick");
            
            int sum = AddTwoNumbers(190, 43);
            double dsum = AddTwoNumbers(119.34, 43.79);
            Console.WriteLine(sum);
            Console.WriteLine(dsum);

            int myAge = CalculateAge(new DateTime(1996, 03, 06));
            Console.WriteLine("My age: " + myAge);
        }
    }
}
