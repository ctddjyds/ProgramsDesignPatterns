using System;

namespace SlashDecorator
{
    public class EspressoBeverage : BeverageAbstract
    {
        public EspressoBeverage()
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
