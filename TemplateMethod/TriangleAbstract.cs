using System;
using System.Drawing ;

namespace TemplateMethod
{
	/// <summary>
	/// Summary description for Triangle.
	/// </summary>
	public abstract class TriangleAbstract
    {
		private Point p1, p2, p3;
		protected Pen pen;
		//-----
		public TriangleAbstract(Point a, Point b, Point c)
        {
			p1 = a;
			p2 =  b;
			p3 = c;
			pen = new Pen(Color.Black , 1);
		}
        /// <summary>
        /// 模板方法，给出了逻辑的骨架，而逻辑的组成是一些相应的抽象操作，它们推迟到子类去实现。
        /// </summary>
        public virtual void draw(Graphics g)
        {
			g.DrawLine (pen, p1, p2);
			Point c = draw2ndLine(g, p2, p3);
			closeTriangle(g, c);
		}
        //一些抽象行为，放到子类去实现
        public abstract Point draw2ndLine(Graphics g, Point a, Point b);

		public void closeTriangle(Graphics g, Point c)
        {
			g.DrawLine (pen, c, p1);
		}
	}
}
