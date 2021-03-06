﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlashDecorator
{
    public class MochaDecorator : CondimentDecoratorAbstract
    {
        public MochaDecorator(BeverageAbstract beverage)
        {
            this.m_beverage = beverage;
        }
        public override double cost()
        {
            return 0.2+m_beverage.cost();
        }
        public override string GetDescription()
        {
            return m_beverage.GetDescription()+",mocha";
        }
    }
}
