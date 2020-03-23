using System;
namespace SlashDecorator
{

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _Description = "DarkRoast";
            CustomBeverageSize = BeverageSize.Tall;
        }
        public override double cost()
        {
            return 2.99;
        }
    }
}
