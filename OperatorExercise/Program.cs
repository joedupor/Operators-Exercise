namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;


            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            double areaOfCircle = Operators.AreaOfCircle();
            Console.WriteLine($"The area of a circle with radius of 20 is {areaOfCircle}");


            int i = 3;
            int j = 4;
            int k = ++i * j++;
            Console.WriteLine(k);


        }
    }
}
