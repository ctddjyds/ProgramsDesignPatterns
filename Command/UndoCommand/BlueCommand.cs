using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections ;

namespace CommandUndo
{
	/// <summary>
	/// draws bluelines and caches list for undo
	/// </summary>
	public class BlueCommand :ColorCommand
    {
		public BlueCommand(PictureBox pict):base(pict)
        {
			color = Color.Blue ;
			x = pbox.Width ;
			dx = -20;
			y = 0;
			dy = 0;
		}
	}
}
