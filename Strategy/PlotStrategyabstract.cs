using System;

namespace Strategy
{
	/// <summary>
	/// Summary description for PlotStrategy.
	/// </summary>
	public abstract class PlotStrategyAbstract
	{
		/// <summary>
		/// �����㷨
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public abstract void plot( float[] x, float[] y);
	}
}
