using System;

namespace Fun_With_Attributes
{
    class Tomato : Vegetable
    {
        // Constructors
        public Tomato() : base("tomato", 1.1, 0.2, 3.8)
        { }


        //Properties
        [ColorAttribute(ConsoleColor.Blue)]
        public override double Proteins
        {
            get { return proteins; }
        }

        [ColorAttribute(ConsoleColor.Red)]
        public override double Carbohydrates
        {
            get { return carbohydrates; }
        }
    }
}
