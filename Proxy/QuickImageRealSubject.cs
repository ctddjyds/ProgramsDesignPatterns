using System;
using System.Drawing ;
namespace Proxy
{
	/// <summary>
	/// Summary description for QuickImage.
	/// </summary>
	public class QuickImageRealSubject : IImageSubject
    {
		public QuickImageRealSubject()	{}
		public Image DrawImage()
        {
			return new Bitmap ("Box.gif");
		}
	}
}
