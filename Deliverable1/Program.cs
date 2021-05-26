using System;

namespace Deliverable1
{
    class Program 
    { 

        public static void Main(string[] args)
        {

            string again = "yes";

            while (again == "yes")

            {

                Console.WriteLine("Please give me a measurement type");
                string measurementtype = Console.ReadLine();

                Console.WriteLine("Please give me an amount");
                double amount = double.Parse(Console.ReadLine());
                double result = 0;

                if (measurementtype == "inch")
                {
                    //convert inch to fidget spinners
                    result = amount * 3.5;
                }
                else if (measurementtype == "foot")
                {
                    //convert foot to memes
                    result = amount * 5;
                }
                else if (measurementtype == "fidget spinners")
                {
                    //convert fidget spinners to inch
                    result = 3.5 / amount;
                }
                else if (measurementtype == "memes")
                {
                    //convert memes to foot
                    result = 5 / amount;
                }

                Console.WriteLine($"The result is {result}");

                Console.WriteLine("Would you like to do another?");
                again = Console.ReadLine();
            }

           

        }
    }
}
