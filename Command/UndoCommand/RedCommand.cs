using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
namespace CommandUndo
{
	/// <summary>
	/// Summary description for RedCommand.
	/// </summary>
	public class RedCommand : ColorCommand 	
	{
		public RedCommand(PictureBox pict):	base(pict)
		{
			color = Color.Red;
			x = 0;
			dx = 20;
			y = 0;
			dy = 0;
		}
	}
}
