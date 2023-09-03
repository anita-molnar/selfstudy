
            using System;
            using System.Diagnostics.Eventing.Reader;
            using System.Net.Http.Headers;
            using System.Runtime.InteropServices;
            using System.Security.Cryptography;
            using System.Web;
            using System.Xml;

namespace Studies

{
    internal class Studies

    {
        static void Main(string[] args)
        {
            string useranswer = "y";
            while (useranswer != "n")
            {

                // Ask user height in meters
                Console.Write("\nPlease enter your height in meters: ");
                double h = Convert.ToDouble(Console.ReadLine());

                // Ask user weight in kgs
                Console.Write("Please enter your weight in kgs: ");
                double w = Convert.ToDouble(Console.ReadLine());

                double BMI = CalculateBmi(h, w);
                Console.WriteLine("\nYour BMI is " + BMI.ToString("F2"));
               
                //Display BMI range

                if (BMI < 18.50)
                {
                    Console.WriteLine("underweight");
                }
                else if (BMI >= 18.50 && BMI <= 24.90)
                {
                    Console.WriteLine("healthy range");
                }
                else if (BMI >= 25 && BMI <= 29.90)
                {
                    Console.WriteLine("overweight");
                }
                else
                {
                    Console.WriteLine("obese");
                }

                // underweight
                if (BMI < 18.50)
                {
                    int countkilos = 0;                    
                    while (CalculateBmi(h, w) < 18.5)
                        {
                            w++;
                            countkilos++;
                        }
                    Console.WriteLine("you should gain " + countkilos + " kilos");                    
                }

                //overweight
                else if (BMI > 24.5)
                {
                    int countkilos = 0;
                    while (CalculateBmi(h, w) > 24.5)
                    {
                        w--;
                        countkilos ++;                 
                    }
                    Console.WriteLine("you should loose " + countkilos + " kilos");

                }

               //Ask user to continue
                Console.WriteLine("");
                Console.WriteLine("Do you want to continue? y/n");

                useranswer = Console.ReadLine();
            }
            Console.WriteLine("Program ended");
            Console.ReadLine();
        }
        static double CalculateBmi(double h, double w)
        {
            double BMI = w / (h * h);
            return BMI;
        }
    }
}      




