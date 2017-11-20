using System;

namespace CHolder
{
	/// <summary>
	/// Summary description for CommandHolder.
	/// </summary>
	public interface ICommandHolder
    {
		Command getCommand();
		void setCommand(Command cmd);
	}
}
