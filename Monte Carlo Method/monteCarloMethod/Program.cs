using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Dynamic;
using System.Transactions;
using System.Security.Cryptography;
// This was a team effort with Patrick Brown, and Johnny Jones.
//1. Why do we multiply the value from step 5 above by 4?
    //Because there's four quadrants and we only use one of them
//2. What do you observe in the output when running your program with parameters of increasing size?
    //More accuracy
//3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
    //No because we are using random numbers
//4. Find a parameter that requires multiple seconds of run time. What is that parameter?
    //The iteration method because its running the for loop 
//5. How accurate is the estimated value of pi?
    //Not really accurate
//6. Research one other use of Monte-Carlo methods.Record it in your exercise submission and be prepared to discuss it in class.
    //Analyzing how a network or electric grid will perform in different scenarios
namespace monteCarloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Monte-Carlo Method");

            // This is because were inputing the four numbers for the homework
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\n\nHow many iterations do you want?"); //This is number 3 for this lab
                int iterations = int.Parse(Console.ReadLine()); // This is also number 3 for this labe
                Iterations(iterations);
            }
            Console.ReadLine();

        }
        // This is number one for this lab
        static Random randomboi = new Random();
        public static double randomboi1 = randomboi.NextDouble();
        public static double randomboi2 = randomboi.NextDouble();

        public static void  Hypotenize() // This is number two for this lab
        {
            double x = randomboi1;
            double y = randomboi2;
            double hypotenuse = Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)));
            Console.WriteLine(hypotenuse);
        }
        public static void Iterations(int iterations) // This is number four for the lab
        {
            int countyboi = 0;
 
           for(int i = 0; i < iterations; i++)
            {
                Random randomboi11 = new Random();
                Random randomboi22 = new Random();
                double x = randomboi11.NextDouble();
                double y = randomboi22.NextDouble();
                double hypotenuse = Math.Sqrt((x * x) + (y * y));
       
                if(hypotenuse <= 1)
                {
                    countyboi++;
                }
               
            }
            double bruh = countyboi;
            double boy = iterations;
            double preanswer = boy / bruh;
            double four = Convert.ToDouble(4.000000000000000000000000000000000000000000);
            double answer = four * preanswer;
            // This is number five for this lab
            Console.WriteLine($"\nThis is the estimate : {answer} \nThis is the difference between the estimate and pi : {Math.Abs(Math.PI - answer)} "); // This is number six for the lab
        }

    }
}
