using System;
using System.Drawing ;
namespace Proxy
{
    /// <summary>
    /// 抽象主题角色(Subject)
    /// </summary>
    public interface IImageSubject
    {
        /// <summary>
        /// 相关逻辑操作,显示图像
        /// </summary>
        /// <returns></returns>
		Image DrawImage();		
	}
}
