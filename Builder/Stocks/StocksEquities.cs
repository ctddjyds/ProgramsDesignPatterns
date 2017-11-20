using System;
using System.Collections ;
/// <summary>
/// Summary description for Stocks.
/// </summary>
public class StocksEquities: EquitiesAbstract
{
    private readonly string _StocksName = "Stocks"; 
	public StocksEquities()
    {
        _Array = new ArrayList();
        _Array.Add("Cisco");
        _Array.Add("Coca Cola");
        _Array.Add("GE");
        _Array.Add("Harley Davidson");
        _Array.Add("IBM");
        _Array.Add("Microsoft");
    }
    public override string ToString()
    {
		return _StocksName;
	}
    public override int GetHashCode()
    {
        return _StocksName.GetHashCode();
    }
}
