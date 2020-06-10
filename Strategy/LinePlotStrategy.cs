using System;

namespace Strategy
{
	/// <summary>
	/// Summary description for LinePlotStrategy.
	/// </summary>
	public class LinePlotStrategy : PlotStrategyAbstract
    {
        public LinePlotStrategy()
        {
            StrategyName = "LinePlot";
        }
		public override void plot(float[] x, float[] y)
        {
			LinePlot lplt = new LinePlot();
			lplt.Show ();
			lplt.plot (x, y);
		}
	}
}
