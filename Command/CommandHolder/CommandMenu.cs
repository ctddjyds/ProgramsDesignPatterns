using System;
using System.Windows.Forms;
namespace CHolder
{
	/// <summary>
	/// Summary description for CommandMenu.
	/// </summary>
	public class CommandMenu : MenuItem, ICommandHolder 	
	{
		private ICommand command;
		public CommandMenu(string name):base(name) 	{}
		//-----	
		public void setCommand (ICommand comd) 
		{
			command = comd;
		}
		//-----	
		 public ICommand getCommand () 
		{
			return command;
		}
	}
}
