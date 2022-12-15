namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder);
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("please enter the radius or your circle:");

            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));

            //var i = 3;
            //var j = 4;
            //var k = ++i * j++;

            //Console.WriteLine(k);   

            
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow( radius, 2);

            return area;    
        }
            



    }
}
