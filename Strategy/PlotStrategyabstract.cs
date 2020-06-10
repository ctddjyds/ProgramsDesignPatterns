using System;

namespace Strategy
{
	/// <summary>
	/// Summary description for PlotStrategy.
	/// </summary>
	public abstract class PlotStrategyAbstract
	{
        public string StrategyName { get; set; }
		public abstract void plot( float[] x, float[] y);
	}
}
