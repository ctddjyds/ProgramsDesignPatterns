using System;
using System.Drawing ;
namespace Proxy
{
    /// <summary>
    /// ���������ɫ(Subject)
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
