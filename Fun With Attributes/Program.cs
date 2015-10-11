using System;

namespace Fun_With_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetable[] vegetables =
            {
                 new Carrot(), 
                 new Tomato(),
                 new Cucumber()
            };
            foreach (Vegetable vegetable in vegetables)
            {
                Printer.ColorPrint(vegetable);
            }
            Console.ReadKey();
        }
    }
}
