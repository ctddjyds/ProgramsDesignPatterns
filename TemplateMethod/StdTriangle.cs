using System;
using System.Drawing ;
namespace TemplateMethod
{
	/// <summary>
	/// Summary description for StdTriangle.
	/// </summary>
	public class StdTriangle :TriangleAbstract
    {
		public StdTriangle(Point a, Point b, Point c) : base(a, b, c)
        { }
		//------
		public override Point draw2ndLine(Graphics g, Point a, Point b)
        {
			g.DrawLine (pen, a, b);
			return b;
		}
	}
}
