using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program takes the numbers 1 to 100 and prints Fizz for numbers divisible by 3");
            Console.WriteLine(" Buzz for numbers divisible by 5");
            Console.WriteLine("and FizzBuzz for numbers divisible by both 3 and 5");
            FizzBuzz f = new FizzBuzz();
            f.fizzbuzz();
        }
    }
}
