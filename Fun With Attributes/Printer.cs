using System;
using System.Reflection;

namespace Fun_With_Attributes
{
    public static class Printer
    {
        // Methods
        public static void ColorPrint(Vegetable vegetable)
        {
            bool hasColorAttribute;

            Type type = vegetable.GetType();
            PropertyInfo[] propsInfo = type.GetProperties();
            foreach (PropertyInfo prop in propsInfo)
            {
                Console.ForegroundColor = ConsoleColor.White;
                hasColorAttribute = false;

                Console.Write("Prop name: " + prop.Name + "; Prop value: ");
                object[] attributes = prop.GetCustomAttributes(true);
                foreach (object att in attributes)
                {
                    if (att is ColorAttribute)
                    {
                        Console.ForegroundColor = ((ColorAttribute) att).PropertyColor;
                        Console.WriteLine(prop.GetValue(vegetable));
                        hasColorAttribute = true;
                    }
                }
                if (!hasColorAttribute)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(prop.GetValue(vegetable));
                }
            }
            Console.WriteLine();
        }
    }
}
