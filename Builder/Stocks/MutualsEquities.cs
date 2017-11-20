using System;
using System.Collections ;

/// <summary>
/// Summary description for Mutuals.
/// </summary>
public class MutualsEquities:EquitiesAbstract
{
    private readonly string _MutualsName = "Stocks";
    public MutualsEquities()
	{
        _Array = new ArrayList();
        _Array.Add("Fidelity Magellan");
        _Array.Add("Lindner");
        _Array.Add("T Rowe Price");
        _Array.Add("Vanguard Primecap");
    }

    public override string ToString()
    {
		return _MutualsName;
	}
    public override int GetHashCode()
    {
        return _MutualsName.GetHashCode();
    }
}
