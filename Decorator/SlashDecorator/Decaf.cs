using System;
namespace SlashDecorator
{

    public class Decaf : Beverage
    {
        public Decaf()
        { _Description = "Decaf"; }
        public override double cost()
        {
            return 3.99;
        }
    }
}
