using System;
using System.Collections ;

/// <summary>
/// Summary description for Bonds.
/// </summary>
public class BondsEquities:EquitiesAbstract
{
    private readonly string _BondsName = "Bonds";
    public BondsEquities()
	{
        _Array = new ArrayList();
        _Array.Add("CT GO 2005");
        _Array.Add("NY GO 2012");
        _Array.Add("GE Corp Bonds");
    }

    public override string ToString()
    {
		return _BondsName;
	}
    public override int GetHashCode()
    {
        return _BondsName.GetHashCode();
    }
}

