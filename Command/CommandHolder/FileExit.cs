using System;
using System.Windows.Forms;
namespace CHolder
{
	/// <summary>
	/// Summary description for FileExit.
	/// </summary>
	public class FileExit :MenuItem, ICommand 	
	{
		private Form form;
		//----------
		public FileExit(Form frm) :base ("Exit") 
		{
			form = frm;
		}
		//----------
		public void Execute() 
		{
			form.Close ();
		}
	}
}
