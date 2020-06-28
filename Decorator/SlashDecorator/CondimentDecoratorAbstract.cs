using System;

namespace SlashDecorator
{
    /// <summary>
    /// Summary description for DecoPanel.
    /// 装饰抽象类继承与Component接口，从外部类扩展Component类的功能
    /// 并维持一个对Component的引用，起到添加职责的功能
    /// </summary>
    public abstract class CondimentDecoratorAbstract : BeverageAbstract
	{
        protected BeverageAbstract m_beverage;
        //public abstract string GetDescription();

    }
}
