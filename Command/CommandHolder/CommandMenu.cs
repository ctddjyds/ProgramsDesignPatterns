using System;
using System.Windows.Forms;
namespace CHolder
{
	/// <summary>
	/// Summary description for CommandMenu.
	/// </summary>
	public class CommandMenu : MenuItem, ICommandHolder 	{
		private Command command;
		public CommandMenu(string name):base(name) 	{}
		//-----	
		public void setCommand (Command comd) {
			command = comd;
		}
		//-----	
		 public Command getCommand () {
			return command;
		}
	}
}
