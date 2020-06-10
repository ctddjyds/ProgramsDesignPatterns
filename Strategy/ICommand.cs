using System;
using CsharpPats;

namespace Strategy
{
	/// <summary>
	/// Command interface
	/// </summary>
	public interface ICommand
	{
        string CommandName { get; set; }
		void Execute();
	}
}
