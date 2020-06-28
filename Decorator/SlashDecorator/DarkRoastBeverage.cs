using System;
namespace SlashDecorator
{

    public class DarkRoastBeverage : BeverageAbstract
    {
        public DarkRoastBeverage()
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
