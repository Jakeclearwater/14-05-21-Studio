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

            string answer;
            do
            {
                Console.WriteLine("is jake the best");
                answer = Console.ReadLine();


                if (answer == "no")
                {
                    Console.WriteLine("Wrong");
                }

            } while(answer != "yes");



            int codys, total, price = 2;
            Console.WriteLine("Please enter how many Cody's you would like");
            temp = Console.ReadLine();
            codys = Convert.ToInt32(temp);
            total = codys * price;
            Console.WriteLine("Your total comes to " + total + "");
   

            string susmeter;

            Console.WriteLine("How sus are you out of 10?");
            susmeter = Console.ReadLine();

            Console.WriteLine($"Dayum shawtyyyyy ug to a sus score of {susmeter}/10 unluggy uce SHEEEEEEEESH");
            Console.ReadLine();



        }
    }
}
