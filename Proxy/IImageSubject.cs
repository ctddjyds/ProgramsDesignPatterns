using System;
using System.Drawing ;
namespace Proxy
{
    /// <summary>
    /// ���������ɫ(Subject)
    /// ������RealSubject��Proxy�Ĺ��нӿڣ����������κ�ʹ��RealSubject�ĵط�������ʹ��Proxy
    /// </summary>
    public interface IImageSubject
    {
        /// <summary>
        /// ����߼�����,��ʾͼ��
        /// </summary>
        /// <returns></returns>
		Image DrawImage();		
	}
}
