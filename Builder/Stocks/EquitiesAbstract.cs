using System;
using System.Collections ;

/// <summary>
/// Summary description for Equities.
/// Builder对象识别器
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
    //Builder的各个具体对象识别器（根据个数确定使用哪个ConcreteBuilder对象）
    public int count()
    {
		return _Array.Count ;
	}
}
