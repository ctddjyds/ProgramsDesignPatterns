using System;
using System.Drawing ;
namespace Proxy
{
    /// <summary>
    /// 抽象主题角色(Subject)
    /// 定义了RealSubject和Proxy的共有接口，这样就在任何使用RealSubject的地方都可以使用Proxy
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
