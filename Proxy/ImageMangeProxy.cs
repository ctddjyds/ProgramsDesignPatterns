using System;
using System.Drawing;
using System.IO;
using System.Threading;
namespace Proxy
{
	/// <summary>
	/// ʹ��ImageManageProxy���д���.
    /// Ϊ���������ṩһ�ִ����Կ��ƶ��������ķ���
	/// </summary>
	public class ImageMangeProxy:IImageSubject
    {		
        //����ʵ�����ɫ��������ã��Ӷ����Բ�����ʵ�����ɫ����
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
        /// ��ͬ��ʵ��ɫ�Ļ�ȡ�����贴����Ӧ����ʵ��ɫ����
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
        /// �������
        /// </summary>
        /// <returns></returns>
        public bool GetGifFrame()
        {
            return true;
        }
	}
}
