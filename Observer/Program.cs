using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormSubject subject = new FormSubject();
            ListObserverForm lobs = new ListObserverForm();
            subject.RegisterInterest(lobs);
            ColorObserverForm colObs = new ColorObserverForm();
            subject.RegisterInterest(colObs);
            Application.Run(subject);
        }
    }
}
