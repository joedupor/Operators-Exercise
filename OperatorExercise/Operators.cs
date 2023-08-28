using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Operators
    {

        public static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2);
        }


    }

}
