using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections ;

namespace CommandUndo
{
	/// <summary>
	/// Summary description for ColorCommand.
	/// </summary>
	public class ColorCommand :ICommand
	{
		protected Color color;			//line color
		protected PictureBox pbox;		//box to draw in
		protected ArrayList drawList;	//list of lines
		protected int x, y, dx, dy;		//coordinates
		//------
		public ColorCommand(PictureBox pict)
		{
			pbox = pict;	//copy in picture box
			drawList = new ArrayList ();	//create list
		}
		//------
		public void Execute()
        {
			//create a new line to draw
			DrawData dl = new DrawData(x, y, dx, dy);
			drawList.Add(dl);	//add it to the list
			x = x + dx;			//increment the positions
			y = y + dy;
			pbox.Refresh();
		}
		//-----
		public bool isUndo()
        {
			return false;
		}
		//-----
		public void Undo()
        {
			DrawData dl;
			int index = drawList.Count - 1;
			if (index >= 0) {
				dl = (DrawData)drawList[index];
				drawList.RemoveAt(index);
				x = dl.getX();
				y = dl.getY();
			}
			pbox.Refresh();
		}
		//-----
		public void draw(Graphics g)
        {
			Pen rpen = new Pen(color, 1);
			int h = pbox.Height;
			int w = pbox.Width;
		    //draw all the lines in the list
			for (int i = 0; i < drawList.Count ; i++) {
				DrawData dl = (DrawData)drawList[i];
				g.DrawLine(rpen, dl.getX(), dl.getY(), dl.getX() + dx, dl.getDy() + h);
			}
		}

	}
}
