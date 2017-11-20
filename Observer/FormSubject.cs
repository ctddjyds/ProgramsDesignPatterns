using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    public partial class FormSubject : Form,ISubject
    {
        private List<IObserver> m_observersList;
        public FormSubject()
        {
            InitializeComponent();
            m_observersList = new List<IObserver>();
            opRed.Click += opButton_Click;
            opBlue.Click += opButton_Click;
            opGreen.Click += opButton_Click;
        }
        public void RegisterInterest(IObserver obs)
        {
            m_observersList.Add(obs);
        }
        private void opButton_Click(object sender, System.EventArgs e)
        {
            RadioButton but = (RadioButton)sender;
            StateStr = but.Text;
            NotifyObversers();
        }
        public string StateStr { get; set ; }

        public void UnRegisterInterest(IObserver obs)
        {
            m_observersList.Remove(obs);
        }

        public void NotifyObversers()
        {
            for (int i = 0; i < m_observersList.Count; i++)
            {
                IObserver obs = m_observersList[i];
                obs.Update(StateStr);
            }
        }
    }
}
