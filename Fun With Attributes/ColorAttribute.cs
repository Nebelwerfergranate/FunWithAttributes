using System;

namespace Fun_With_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class ColorAttribute : Attribute
    {
        // Fields
        private ConsoleColor propertyColor;


        // Constructors
        public ColorAttribute()
        {
            propertyColor = ConsoleColor.White;
        }

        public ColorAttribute(ConsoleColor propertyColor)
        {
            this.propertyColor = propertyColor;
        }
 

        // Properties
        public ConsoleColor PropertyColor
        {
            get { return propertyColor;}
        }
    }
}
