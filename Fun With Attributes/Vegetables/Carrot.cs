using System;

namespace Fun_With_Attributes
{
    public class Carrot : Vegetable
    {
        // Constructors
        public Carrot() :base("carrot", 1.3, 0.1, 6.9)
        { }


        // Properties
        [ColorAttribute(ConsoleColor.Cyan)]
        public override double Proteins
        {
            get { return proteins; }
        }
        [ColorAttribute(ConsoleColor.Yellow)]
        public override double Carbohydrates
        {
            get { return carbohydrates; }
        }
    }
}
