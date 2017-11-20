using System;
/// <summary>
/// Summary description for StockFactory.
/// 导向器工厂Director
/// </summary>
public class DirectorFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="equities"></param>
    /// <returns></returns>
	public static IChoiceBuilder GetBuilder(EquitiesAbstract equities)
	{
        //通过Builder中的ConcreteBuilder生成部件，并通知生成（根据个数确定使用哪个ConcreteBuilder对象）
        if (equities.count ()<=3)
        {
            IChoiceBuilder checkBuilder= new CheckChoiceBuilder();
            checkBuilder.BuilderArray(equities);//产品创建过程在 ConcreteBuilder对象中
            checkBuilder.BuilderPanel();
            return checkBuilder;

        }
		else
        {
            IChoiceBuilder listBuilder = new ListChoiceBuilder();
            listBuilder.BuilderArray(equities);//产品创建过程在 ConcreteBuilder对象中
            listBuilder.BuilderPanel();
            return listBuilder;
		}
	}
}

