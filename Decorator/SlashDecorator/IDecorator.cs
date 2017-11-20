using System;
using System.Drawing ;
using System.Windows.Forms ;
namespace SlashDecorator
{
	/// <summary>
	/// Summary description for Decorator.
	/// </summary>
	public interface IDecorator
    {
		void mouseMove(object sender, MouseEventArgs e);
		void mouseEnter(object sender, EventArgs e);
		void mouseLeave(object sender, EventArgs e);
		void paint(object sender, PaintEventArgs e);
	}
}
