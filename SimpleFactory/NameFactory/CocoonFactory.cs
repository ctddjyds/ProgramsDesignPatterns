using System;

namespace FFT
{
	/// <summary>
	/// Summary description for Cocoon.
    /// 简单工厂,方法一般都是静态的
	/// </summary>
	public class CocoonFactory
    {
		static public Butterfly getButterfly(float y)
        {
			if (y != 0)
				return new TrigButterfly(y);
			else
				return new AddButterfly(y);
		}
	}
}
