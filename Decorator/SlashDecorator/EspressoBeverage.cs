using System;

namespace SlashDecorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _Description = "Espresso";
            CustomBeverageSize = BeverageSize.Tall;
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
