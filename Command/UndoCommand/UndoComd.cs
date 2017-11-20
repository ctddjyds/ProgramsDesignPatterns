using System;
using System.Drawing ;
using System.Windows.Forms;
using System.Collections ;

namespace CommandUndo
{
	/// <summary>
	/// Summary description for UndoCommand.
	/// </summary>
	public class UndoComd:ICommand
    {
		private ArrayList undoList;
		public UndoComd()
        {
			undoList = new ArrayList ();
		}
		//-----
		public void add(ICommand comd)
        {
			if(! comd.isUndo ()) {
				undoList.Add (comd);
			}
		}
		//-----
		public bool isUndo()
        {
			return true;
		}
		//-----
		public void Undo() {		}
		//-----
		public void Execute()
        {
			int index = undoList.Count - 1;
			if (index >= 0) {
				ICommand cmd = (ICommand)undoList[index];
				cmd.Undo();
				undoList.RemoveAt(index);
			}
		}
	}
}
