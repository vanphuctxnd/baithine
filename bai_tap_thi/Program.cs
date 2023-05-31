using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_thi
{
        class Cylinder
        {
            private double radius;
            private double height;
            private double baseArea;
            private double lateralArea;
            private double totalArea;
            private double volume;

            public void Process()
            {
            Console.WriteLine("Enter the dimensions of the cylinder");
            Console.Write("Radius : ");
                radius = Convert.ToDouble(Console.ReadLine());

                Console.Write("Height : ");
                height = Convert.ToDouble(Console.ReadLine());

            baseArea = Math.Round(Math.PI * radius * radius, 2);
            lateralArea = Math.Round(2 * Math.PI * radius * height, 2);
            totalArea = Math.Round(2 * Math.PI * radius * (height + radius), 2);
            volume = Math.Round(Math.PI * radius * radius * height, 2);
        }

            public string Result()
            {
                return $" \nBase: { baseArea} Latera : { lateralArea} Total : { totalArea} Volume :  {volume}";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Cylinder cylinder = new Cylinder();
                cylinder.Process();

                Console.WriteLine("\nCylinder Characteristic:");
                Console.WriteLine(cylinder.Result());

                Console.ReadLine();
            }
        }
}
