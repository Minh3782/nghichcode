// See https://aka.ms/new-console-template for more information
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant and GetType method
            const string name = "Manila";
            Console.WriteLine(name);
            Console.WriteLine(name.GetType());

            ////Random number
            //Console.WriteLine("Random number excercise");
            //Random rand = new Random();
            //int number = rand.Next(1, 32);
            //Console.WriteLine(number);
            //Console.WriteLine(++number);
            //Random rand2 = new Random();
            //double number2 = rand2.NextDouble();
            //if(number2 >0.5)
            //{
            //    Console.WriteLine(Math.Ceiling(number2));
            //}
            //else
            //        {
            //    Console.WriteLine(Math.Floor(number2));
            //}

            //Basic Math operations
            Random mathran = new Random();
            int powerresult = mathran.Next(-9, 12);
            //powerresult = Math.Abs(powerresult);
            //Console.WriteLine(Math.Pow(powerresult, 3));
            //Console.WriteLine(Math.Sqrt(powerresult));

            //Random power = new Random(23);
            //int equalresult = power.Next(-9, 10);
            //equalresult = Math.Abs(equalresult);
            //Console.WriteLine(Math.Pow(equalresult, 2));
            //Console.WriteLine( Math.Sqrt(equalresult));
            if (powerresult < 0)
            {
                powerresult = Math.Abs(powerresult);
                Console.WriteLine(Math.Pow(powerresult, 3));
            }
            else
            {
                Console.WriteLine(Math.Sqrt(powerresult));
            }

            /*There are other operation:
             *  round, ceiling, floor
             *  min, max*/
            
            //Length method
            string result = Convert.ToString(powerresult);
            Console.WriteLine(result.Length);

        }
    }
}