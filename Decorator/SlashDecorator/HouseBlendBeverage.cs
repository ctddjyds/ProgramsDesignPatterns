using System;
namespace SlashDecorator
{

    public class HouseBlend : BeverageAbstract
    {
        public HouseBlend()
        {
            _Description = "House Blend Coffee";
            CustomBeverageSize = BeverageSize.Tall;
        }
        public override double cost()
        {
            return 0.99;
        }
    }
}
