using System;

namespace CommandUndo
    {
	/// <summary>
	/// Summary description for CommandHolder.
	/// </summary>
	public interface CommandHolder
    {
		ICommand getCommand();
		void setCommand(ICommand cmd);
	}
}
