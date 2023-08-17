using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Web;
using System.Xml;

namespace MyProject
{
    internal class Program
    {



        static void Main(string[] args)
        {
            string useranswer = "y";
            while (useranswer != "n")
            {


                // Ask user height in meters
                Console.Write("Please enter your height in meters: ");
                double h = Convert.ToDouble(Console.ReadLine());

                // Ask user weight in kgs
                Console.Write("Please enter your weight in kgs: ");
                double w = Convert.ToDouble(Console.ReadLine());

                double BMI = CalculateBmi(h, w);
                Console.WriteLine("Your BMI is " + BMI.ToString("F2"));
                //Console.ReadLine();

                //Display BMI range
                string bmiRange;
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

                Console.WriteLine("You are currently in the " + bmiRange + "range.");

                

                //Ask user to continue
                Console.WriteLine("");
                Console.WriteLine("Do ypu want to continue? y/n");
                Console.WriteLine("");  
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
   
