using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InversionOfControl
{
    public class SetterServiceClassProvider : IServiceClassProvider
    {
        public void Run(Action action)
        {
            throw new NotImplementedException();
        }

        public string ServiceInfo()
        {
            return "我是SetterServiceClassProvider";
        }
    }
}
