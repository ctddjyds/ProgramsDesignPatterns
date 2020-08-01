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
        /// ģ�巽�����������߼�/�㷨�ĹǼܣ����߼�/�㷨�������һЩ��Ӧ�ĳ�������������Ƴٵ�����ȥʵ�֡�
        /// ģ�巽��ʹ��������Բ��ı�һ���㷨�Ľṹ�����ض�����㷨��ĳЩ�ض�����
        /// </summary>
        public virtual void draw(Graphics g)
        {
			g.DrawLine (pen, p1, p2);
			Point c = draw2ndLine(g, p2, p3);
			closeTriangle(g, c);
		}
        //һЩ������Ϊ���ŵ�����ȥʵ��
        public abstract Point draw2ndLine(Graphics g, Point a, Point b);
        /// <summary>
        /// ����/��������Ϊ��ȥ�������е��ظ�����
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
		public void closeTriangle(Graphics g, Point c)
        {
			g.DrawLine (pen, c, p1);
		}
	}
}
