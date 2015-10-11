using System;

namespace Fun_With_Attributes
{
    public class Cucumber : Vegetable
    {
        // Constructors
        public Cucumber() :base("cucumber", 0.8, 0.1, 2.5)
        { }


        // Properties
        [ColorAttribute(ConsoleColor.DarkBlue)]
        public override double Proteins
        {
            get { return proteins; }
        }

        [ColorAttribute(ConsoleColor.DarkRed)]
        public override double Carbohydrates {
            get { return carbohydrates; }
        }
    }
}
