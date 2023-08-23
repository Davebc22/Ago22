namespace Ago22Class
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(Class1.Promedio(a, b, c)); // Llamar clase
        }
    }
}
