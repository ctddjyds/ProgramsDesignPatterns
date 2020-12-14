using System;
using System.Windows.Forms;
using System.Drawing ;
namespace CHolder
{
	/// <summary>
	/// Summary description for cmdRed.
	/// </summary>
	public class RedCommand : ICommand 	
	{
		private Control window;
		//-----
		public RedCommand(Control win)
        {
			window = win;
		}
		//-----
		void ICommand.Execute () 
		{
			window.BackColor =Color.Red ;
		}
	}
}
