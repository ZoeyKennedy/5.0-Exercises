﻿namespace _5._0_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Person1;
            int Person2;
            int Person3;


            Console.WriteLine("What is the age of Person 1?");
            Person1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 1 is "+ Person1 + " years old.");
            Console.WriteLine("What is the age of Person 2?");
            Person2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 1 is " + Person2 + " years old.");
            Console.WriteLine("What is the age of Person 3?");
            Person3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 3 is " + Person3 + " years old.");

            if (Person1 > Person2)
            {
                Console.WriteLine("Person 1 is older than Person 2");
                //good
            }
            if (Person3 < Person1)
            {
                Console.WriteLine("Person 3 is younger than Person 1");
                //good
            }
            if (Person2 == Person3)
            {
                Console.WriteLine("Person 2 and Person 3 are the same age");
            }

        }

    }
}
