using System;
using System.Collections ;

/// <summary>
/// Summary description for Equities.
/// Builder����ʶ����
/// </summary>
public abstract class EquitiesAbstract
{
	protected ArrayList _Array;
    /// <summary>
    /// GetResult
    /// </summary>
    /// <returns></returns>
	public ArrayList GetResult()
    {
		return _Array;
	}
    //Builder�ĸ����������ʶ���������ݸ���ȷ��ʹ���ĸ�ConcreteBuilder����
    public int count()
    {
		return _Array.Count ;
	}
}
