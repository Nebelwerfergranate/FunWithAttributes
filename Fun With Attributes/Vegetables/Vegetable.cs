using System;

namespace Fun_With_Attributes
{
    public abstract class Vegetable
    {
        // Fields
        protected string name;
        protected double proteins;
        protected double fats;
        protected double carbohydrates;


        // Constructors
        public Vegetable(string name, double proteins, double fats, double carbohydrates)
        {
            this.name = name;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
        }


        // Properties
        [ColorAttribute(ConsoleColor.Green)]
        public string Name
        {
            get { return name; }
        }

        public virtual double Proteins
        {
            get { return proteins; }
            private set
            {
                if (value > 100 || value < 0)
                {
                    throw new ApplicationException("Значение свойства должно быть в диапазоне от 0 до 100");
                }
                    proteins = value;
            }
        }

        public double Fats
        {
            get { return fats;}
            private set
            {
                if (value > 100 || value < 0)
                {
                    throw new ApplicationException("Значение свойства должно быть в диапазоне от 0 до 100");
                }
                fats = value;
            }
        }

        public virtual double Carbohydrates
        {
            get { return carbohydrates;}
            private set
            {
                if (value > 100 || value < 0)
                {
                    throw new ApplicationException("Значение свойства должно быть в диапазоне от 0 до 100");
                }
                carbohydrates = value;
            }
        }
    }
}
