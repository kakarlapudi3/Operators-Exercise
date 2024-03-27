namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($" {a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine($" What is the radius of your circle?");
            string userInput = Console.ReadLine();
            double radius = double.Parse(userInput);
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }
        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }




    }
}
