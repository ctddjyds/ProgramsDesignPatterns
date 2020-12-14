using System;

namespace CHolder
{
	/// <summary>
	/// Summary description for CommandHolder.
	/// </summary>
	public interface ICommandHolder
    {
		ICommand getCommand();
		void setCommand(ICommand cmd);
	}
}
