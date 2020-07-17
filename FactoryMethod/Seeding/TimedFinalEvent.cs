using System;

namespace Seeding
{
	/// <summary>
	///class describes an event that will be swum twice
	/// </summary>
	public class TimedFinalEvent:EventCreatorAbstract
    {	
		public TimedFinalEvent(string filename, int lanes):base(filename, lanes)
        {}
		//return StraightSeeding class
	    public override SeedingProductAbstract getSeeding()
        {
			return new StraightSeeding(swimmers, numLanes);
	    }
		public override bool isPrelim()
        {
			return false;
		}
		public override bool isFinal()
        {
			return false;
		}
		public override bool isTimedFinal()
        {
			return true;
		}
	}
}
