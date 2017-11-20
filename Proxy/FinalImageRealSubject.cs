using System;
using System.Drawing ;
namespace Proxy
{
	/// <summary>
	/// Summary description for FinalImage.
	/// </summary>
	public class FinalImageRealSubject :IImageSubject
    {
		public FinalImageRealSubject()
        { }
		public Image DrawImage()
        {
			return new Bitmap("flowrtree.jpg");
		}
	}
}
