using System;
using System.Drawing ;
using System.Windows.Forms ;
namespace SlashDecorator
{
    public enum BeverageSize
    {
        Tall,
        Grande,
        Venti,
    }

    public abstract class Beverage
    {
        protected string _Description = "Unknown Beverage";
        public abstract double cost();
        public BeverageSize CustomBeverageSize { get; set; }
        public virtual string GetDescription()
        {
            return _Description;
        }
	}
}
