using System;

namespace Fun_With_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class ColorAttribute : Attribute
    {
        // Constructors
        public ColorAttribute()
        {
            Color = ConsoleColor.White;
        }

        public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }


        // Properties
        public ConsoleColor Color;
    }
}
