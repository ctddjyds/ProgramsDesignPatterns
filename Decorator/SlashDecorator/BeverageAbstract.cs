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
    /// <summary>
    /// Component定义一个对象接口
    /// 无需知道Decorator的存在
    /// </summary>
    public abstract class BeverageAbstract
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
