using System;

namespace Seeding
{
	/// <summary>
	/// Summary description for PrelimEvent.
    /// 具体工厂类
	/// </summary>
	public class PrelimEvent:EventCreator
	{
		public PrelimEvent(string filename, int lanes):base(filename,lanes)
        {  }
		//return circle seeding
		public override SeedingProduct getSeeding()
        {
			return new CircleSeeding(swimmers, numLanes);
		}
		public override bool isPrelim()
        {
			return true;
		}
		public override bool isFinal()
        {
			return false;
		}
		public override bool isTimedFinal()
        {
			return false;
		}
	}
}
