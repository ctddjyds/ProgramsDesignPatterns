using System;

namespace Gardener
{
	/// <summary>
	/// Summary description for VeggieGarden.
    /// 具体工厂类，一般定义为单例模式
	/// </summary>
	public class VeggieGarden : Garden
    {
		public VeggieGarden()
        {
			shade = new Plant("Broccoli");
			border = new Plant ("Peas");
			center = new Plant ("Corn");
		}
	}
}
