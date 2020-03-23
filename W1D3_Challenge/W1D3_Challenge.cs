using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace W1D3_Challenge
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void Test()
            {
            string word = "Supercalifragilisticexpialidocious";
            Console.WriteLine(word.Length); //Second part of the challenge
            Console.WriteLine("Enter a number and I will tell you the corresponding letter ");
            int userChoice = Int32.Parse(Console.ReadLine());
            char[] arr = word.ToCharArray();
                foreach (char letter in arr) //First part of challenge
                {
                Console.WriteLine(letter);
                }

                foreach (char letter in arr)
                {
                if (letter == 'i') {
                    Console.WriteLine(letter);
                }
                else if(letter == 'l'){
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or a l");
                }

                Console.WriteLine(arr[userChoice]);
            }
          }
        }
    }

