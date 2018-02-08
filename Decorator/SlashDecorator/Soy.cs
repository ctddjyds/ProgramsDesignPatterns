using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashDecorator
{
    public class Soy : CondimentDecorator
    {
        private Beverage m_beverage;
        public Soy(Beverage beverage)
        { this.m_beverage = beverage; }
        public override double cost()
        {
            if(m_beverage.CustomBeverageSize==BeverageSize.Grande)
                return 0.1+m_beverage.cost();
            else if(m_beverage.CustomBeverageSize == BeverageSize.Tall)
                return 0.5 + m_beverage.cost();
            else
                return 0.2 + m_beverage.cost();
        }
        public override string GetDescription()
        {
            return m_beverage.GetDescription()+ ",Soy";
        }
    }
}
