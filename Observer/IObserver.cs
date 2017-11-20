using System;

namespace Observer
{
	/// <summary>
	/// Summary description for Observer.
	/// </summary>
	public interface IObserver
    {
		void Update(string message);
	}
}
