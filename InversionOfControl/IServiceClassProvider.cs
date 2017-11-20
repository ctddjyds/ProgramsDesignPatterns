using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InversionOfControl
{
    /// <summary>
    /// 定义注入接口/服务类接口
    /// </summary>
    public interface IServiceClassProvider
    {
        string ServiceInfo();
        void Run(Action action);
    }
}
