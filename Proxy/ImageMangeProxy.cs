using System;
using System.Drawing;
using System.IO;
using System.Threading;
namespace Proxy
{
	/// <summary>
	/// 使用ImageManageProxy进行代理.
    /// 为其它对象提供一种代理以控制对这个对象的访问
	/// </summary>
	public class ImageMangeProxy:IImageSubject
    {		
        //对真实主题角色对象的引用，从而可以操作真实主题角色对象
        private IImageSubject m_imgSubject;
        private string m_imgFileName;
        public ImageMangeProxy()
        {
		}
		public ImageMangeProxy(string imgFile):this()
        {
            m_imgFileName = imgFile;
        }
        /// <summary>
        /// 不同真实角色的获取，按需创建对应的真实角色对象
        /// </summary>
        /// <param name="id"></param>
		public void GetRealSubject()
        {
            if (Path.GetExtension(m_imgFileName) == ".jpg")
                m_imgSubject = new FinalImageRealSubject();
            else
                m_imgSubject = new QuickImageRealSubject();
		}
		public Image DrawImage()
        {
            GetRealSubject();
            if (m_imgSubject != null)
                return m_imgSubject.DrawImage();
            else
                return null;
		}
        /// <summary>
        /// 格外操作
        /// </summary>
        /// <returns></returns>
        public bool GetGifFrame()
        {
            return true;
        }
	}
}
