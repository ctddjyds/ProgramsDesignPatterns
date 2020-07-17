using System;
using System.Collections;
using CsharpPats;

namespace Seeding
{
    /// <summary>
    /// Summary description for Event.
    /// 抽象工厂类--定义一个创建对象的接口，让抽象工厂类的实现类实例化产品类
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
