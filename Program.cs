using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    class Program
    {
        static void Main()
        {
            start:
            Console.WriteLine("What currency are you converting to naira? Dollars, Pounds or Euro?");
            var current_currency = Console.ReadLine();
            
            double result;
            //bool outcome = false;

            double conv_value;
           
            while (true)
            {
               
                if (current_currency.ToLower() == "dollars"|| current_currency.ToLower() == "pounds" || current_currency.ToLower() == "euro")
                {
                    Console.WriteLine("How much "+ current_currency+ " do you want to convert");
                    try
                    {
                        conv_value = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (System.FormatException )
                    {
                        Console.WriteLine("Input a number");
                        goto start;
                        
                    }
                    if (current_currency.ToLower() == "dolars")
                    {
                        result =  conv_value * 415.87;
                        Console.WriteLine(conv_value +" "+ current_currency+ " = "+  result+" naira");
                    }
                    else if (current_currency.ToLower() =="pounds")
                    {
                        result =  conv_value * 505.83;
                        Console.WriteLine(conv_value +" "+ current_currency+ " = "+  result+" naira");

                    }
                    else if (current_currency.ToLower() =="euro")
                    {
                        result =  conv_value * 424.08;
                        Console.WriteLine(conv_value +" " + current_currency+ " = "+  result+" naira");

                    }
                    Console.ReadLine();
                     

                }
                else
                {
                    Console.WriteLine("Input either dollars, pounds or euro");
                    goto start;

                    
                }
               
            }

            






        }
    }
}
