using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InversionOfControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IServiceClassProvider setterProvider = new SetterServiceClassProvider();
            IServiceClassProvider ConstructorProvider = new ConstructorServiceClassProvider();
            ClientClassHost setterHost = new ClientClassHost();
            setterHost.Set_ServiceImpl(setterProvider);
            setterHost.ShowInfo();
            ClientClassHost constructorHost = new ClientClassHost(ConstructorProvider);
            constructorHost.ShowInfo();
            ClientClassHost interfaceHost = new ClientClassHost("DefaultServiceClassProvider");
            interfaceHost.ShowInfo();
            Application.Run(new Form1());
        }
    }
}
