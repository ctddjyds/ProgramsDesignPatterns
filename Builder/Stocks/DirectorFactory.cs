using System;
/// <summary>
/// Summary description for StockFactory.
/// ����������Director
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
        //ͨ��Builder�е�ConcreteBuilder���ɲ�������֪ͨ���ɣ����ݸ���ȷ��ʹ���ĸ�ConcreteBuilder����
        if (equities.count ()<=3)
        {
            IChoiceBuilder checkBuilder= new CheckChoiceBuilder();
            checkBuilder.BuilderArray(equities);//��Ʒ���������� ConcreteBuilder������
            checkBuilder.BuilderPanel();
            return checkBuilder;

        }
		else
        {
            IChoiceBuilder listBuilder = new ListChoiceBuilder();
            listBuilder.BuilderArray(equities);//��Ʒ���������� ConcreteBuilder������
            listBuilder.BuilderPanel();
            return listBuilder;
		}
	}
}

