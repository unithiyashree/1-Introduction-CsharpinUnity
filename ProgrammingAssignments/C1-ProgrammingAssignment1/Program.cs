using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message 
            Console.WriteLine("Welcome : The application will calculate the distance between two points and the angle between those points.");
            Console.WriteLine();

            Console.Write("𝙴𝚗𝚝𝚎𝚛 𝚏𝚒𝚛𝚜𝚝 𝚡1 𝚟𝚊𝚕𝚞𝚎: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("𝙴𝚗𝚝𝚎𝚛 𝚏𝚒𝚛𝚜𝚝 y1 𝚟𝚊𝚕𝚞𝚎: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.Write("𝙴𝚗𝚝𝚎𝚛 𝚏𝚒𝚛𝚜𝚝 𝚡2 𝚟𝚊𝚕𝚞𝚎: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("𝙴𝚗𝚝𝚎𝚛 𝚏𝚒𝚛𝚜𝚝 y2 𝚟𝚊𝚕𝚞𝚎: ");
            float point2Y = float.Parse(Console.ReadLine());

            float delX = point2X - point1X;
            float delY = point2Y - point1Y;

            double c = Math.Pow((double)delX, 2) + Math.Pow((double)delY, 2);
            c = Math.Sqrt(c);
            float distance = (float)c;
            Console.WriteLine("The distance between the two points is " + distance);
            Console.WriteLine();

            double radians = (double)Math.Atan2(delY, delX);
            double angle = radians * (180 / Math.PI);
            Console.WriteLine("The angle between the two points is " + angle);
            Console.WriteLine();

        }
    }
}
