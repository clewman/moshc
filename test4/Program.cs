using test4.Math;
using System;

namespace test4
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirmail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World 2");
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Cheryl";
            bool isWorking = false;
            //can all be represented by var and var makes assumptions about their type
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

             try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted t oa byte");
            }

             Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

             var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "jack", "john", "mary" };
            Console.WriteLine(names[1]);
            ar firstName = "Cheryl";
            var lastName = "Lewman";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

             
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);*/

          
           
            Console.WriteLine("Enter a number between 1 and 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
           

        }
    }
}
