using System;

namespace _14_05_21_studio
{
    class Program
    {
        static void Main(string[] args)
        {

            string temp, name;
            int age;

            Console.WriteLine("Hi there please enter your age");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);



            Console.WriteLine("Enter your name please!");
            name = Console.ReadLine();



            Console.WriteLine($"your name is {name} and you are {age} years old");
            Console.ReadLine();



















        }
    }
}
