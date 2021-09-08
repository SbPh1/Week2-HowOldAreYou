using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaasta
            //programm kuvab kasutaja sünniaasta konsoolis

            Console.WriteLine("How old are you?");

            //Convert string from ReadLine() to int
            int Age = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - Age;

            Console.WriteLine($"You're born in {YearOfBirth}.");

        }
    }
}
