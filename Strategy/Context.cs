using System;
using System.Collections ;
using CsharpPats;
namespace Strategy
{
    /// <summary>
    /// Selects which plot strategy to carry out
    /// ������ɫ��Context��������һ��Strategy�����������
    /// </summary>
    public class Context
    {
        /// <summary>
        /// ����ģʽ�ͼ򵥹�������ϡ���ʵ����������ԵĹ����ɿͻ���ת�Ƶ�Context����
        /// �ͻ���ֻ����ʶһ����Context��������ϣ�ʹ����Ĳ����㷨�Ϳͻ��˷���
        /// </summary>
        /// <param name="strategyName"></param>
        public Context(string strategyName)
        {
            switch(strategyName)
            {
                case "BarPlot":
                    plts = new BarPlotStrategy();
                    break;
                case "LinePlot":
                    plts = new LinePlotStrategy();
                    break;
            }
        }
		float[] x, y;
		PlotStrategyAbstract plts;	//strategy selected goes here
		//-----�����Ľӿڣ����ݾ���Ĳ��Զ��󣬵������㷨�ķ���
		public void plot()
        {
			readFile();		//read in data
			plts.plot(x, y);
		}
		
		//-----
		public void readFile()
        {
			ArrayList xc = new ArrayList();
			ArrayList yc = new ArrayList();
                        
            //reads data in from data file
			csFile fl = new csFile("data.txt");
			fl.OpenForRead();
			string sline = fl.readLine ();
			while (sline != null)
            {
				int i = sline.IndexOf(" ");
				if (i > 0)
                {
					float tmp = Convert.ToSingle (sline.Substring (0, i));
					xc.Add(tmp);  
					tmp = Convert.ToSingle (sline.Substring(i + 1));
					yc.Add(tmp);
				}
				sline = fl.readLine();
			}
			//copy into arrays from collections
			float[] xp = new float[xc.Count];
			float[] yp = new float[yc.Count];
			for (int i = 0; i< xc.Count; i++)
            {
				xp[i] = (float)xc[i];
				yp[i] = (float)yc[i];
			}
			x = xp;
			y = yp;
			fl.close();			
		}
	}
}
