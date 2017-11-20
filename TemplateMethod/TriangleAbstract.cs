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
        /// ģ�巽�����������߼��ĹǼܣ����߼��������һЩ��Ӧ�ĳ�������������Ƴٵ�����ȥʵ�֡�
        /// </summary>
        public virtual void draw(Graphics g)
        {
			g.DrawLine (pen, p1, p2);
			Point c = draw2ndLine(g, p2, p3);
			closeTriangle(g, c);
		}
        //һЩ������Ϊ���ŵ�����ȥʵ��
        public abstract Point draw2ndLine(Graphics g, Point a, Point b);

		public void closeTriangle(Graphics g, Point c)
        {
			g.DrawLine (pen, c, p1);
		}
	}
}
