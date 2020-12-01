using System;

namespace CircleApp_MethodsOnly
{
    class Program
    {
        public static double RequestRadius()
        {
            Console.Write("Please enter the radius of the circle: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double CalculateArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

        public static double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public static void OutputArea(double radius, double area)
        {
            Console.WriteLine("For a circle with a radius of "
                + radius + " the area is " + area);
        }

        public static void OutputCircumference(double radius, double circumference)
        {
            Console.WriteLine("For a circle with a radius of "
                + radius + " the circumference is " + circumference);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to super fancy circle app.");

            // 1 - Wat is de straal ?
            double radius = RequestRadius();

            // 2 - Oppervlakte berekenen
            double area = CalculateArea(radius);

            // 3 - Omtrek berekenen
            double circumference = CalculateCircumference(radius);

            // 4 - Resultaat
            Console.WriteLine("\n--------------------------------------------\n");
            OutputArea(radius, area);
            OutputCircumference(radius, circumference);
        }
    }
}
