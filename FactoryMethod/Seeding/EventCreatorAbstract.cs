using System;
using System.Collections;
using CsharpPats;

namespace Seeding
{
    /// <summary>
    /// Summary description for Event.
    /// ���󹤳���--����һ����������Ľӿڣ��ó��󹤳����ʵ����ʵ������Ʒ��
    /// </summary>
    public abstract class EventCreatorAbstract
    {
		protected int numLanes;
		protected ArrayList swimmers;

		public EventCreatorAbstract(string filename, int lanes)
        {
			numLanes = lanes;
			swimmers = new ArrayList();
			//read in swimmers from file
			FileOperate f = new FileOperate(filename);
			f.OpenForRead ();
			string s = f.readLine();
			while (s != null)
            {
				Swimmer sw = new Swimmer(s);
				swimmers.Add (sw);
				s = f.readLine();
			}
			f.close();
		}
		public abstract SeedingProductAbstract getSeeding();
		public abstract bool isPrelim();
		public abstract bool isFinal();
		public abstract bool isTimedFinal();
	}
}
