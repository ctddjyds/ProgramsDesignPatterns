using System;
using System.Windows.Forms;
namespace ChainOfResponsibility
{
	/// <summary>
	/// handles command that is not otherwise legal
	/// </summary>
	public class NoCmdChain :Chain
    {
		private ListBox lsNocmd;	//commands go here
		//-----
		public NoCmdChain(ListBox lb)
        {
			lsNocmd = lb;			//copy reference
		}
		//-----
		public override void sendToChain(string mesg)
        {
			//adds unknown commands to list box
			lsNocmd.Items.Add (mesg);
		}
	}
}
