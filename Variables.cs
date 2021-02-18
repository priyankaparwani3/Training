using System;

namespace Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            var number = 256987423;
            var count = 10;
            var price = 20.95f;
            var character = 'A';
            var firstName = "Priyanka";
            var working = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(working);
            Console.WriteLine("{0} {1}", byte.MinValue , byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float pi = 3.14f;
        
        }

    }
}
