using System;

namespace LC_Studio_Ch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            string rInput;
            
            Console.WriteLine("Enter a radius: ");
            rInput = Console.ReadLine();
            radius = double.Parse(rInput);

            double area = Math.PI * (Math.Pow(radius, 2));
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;

            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
            Console.WriteLine($"The circumference of a circle with radius {radius} is: {circumference}");
            Console.WriteLine("The diameter of a circle with radius " + radius + " is: " + diameter);

            double mpg;
            string mpgInput;
            double gallons;

            Console.WriteLine("Enter your car's miles per gallon: ");
            mpgInput = Console.ReadLine();
            mpg = double.Parse(mpgInput);
            gallons = circumference / mpg;

            Console.WriteLine($"It will take {gallons} gallons of gas for your car to go around this circle.");
        }
    }
}
