using System;

namespace SlashDecorator
{
    /// <summary>
    /// Summary description for DecoPanel.
    /// װ�γ�����̳���Component�ӿڣ����ⲿ����չComponent��Ĺ���
    /// ��ά��һ����Component�����ã������ְ��Ĺ���
    /// </summary>
    public abstract class CondimentDecoratorAbstract : BeverageAbstract
	{
        protected BeverageAbstract m_beverage;
        //public abstract string GetDescription();

    }
}
