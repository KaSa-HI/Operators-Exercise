namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1: Int Variables
            int a = 17;
            int b = 4;
            // Console.WriteLine(a + b);
            // Console.WriteLine(a - b);
            // Console.WriteLine(a * b);
            // Console.WriteLine(a / b);
            // Console.WriteLine(a % b);

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"17/4 is 4 remainder + {remainder}");
            }

            // Exercise 2: Area of Circle
            Console.WriteLine("What is the radius of your circle");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle with the radius of {radius} is {area}");

            // Thought Exercise:
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
        }
    }
}

