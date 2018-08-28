using System;

namespace FahrToCel
{
    class Program
    {
    


        static void Main(string[] args)
        {
            Console.Write("Please enter a temperature in degrees fahrenheit: ");
            int temperature = Convert.ToInt32(Console.ReadLine());
            

             
            double c = (temperature - 32) * 5 / 9;
            Console.WriteLine(temperature + " degrees fahrenheit is " + c + " degrees celsius");
            Console.ReadLine();
                
            

            
        }


        
    }
}
