﻿using System;

namespace _14_05_21_studio
{
    class Program
    {
        static void Main(string[] args)
        {

            string temp, name;
            int age;
            Console.WriteLine(" Please enter your age!");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);
            Console.WriteLine("Whats ya name cuh");
            name = Console.ReadLine();

            Console.WriteLine($"Your name is {name} and you are {age} years old");
            Console.ReadLine();





















            int codys, total, price = 2;
            Console.WriteLine("Please enter how many Cody's you would like");
            temp = Console.ReadLine();
            codys = Convert.ToInt32(temp);
            total = codys * price;
            Console.WriteLine("Your total comes to " + total + "");
             

            


















































        }
    }
}
