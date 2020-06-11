using System;
using System.Collections ;
using CsharpPats;
namespace Strategy
{
    /// <summary>
    /// Selects which plot strategy to carry out
    /// 环境角色（Context）：持有一个Strategy抽象类的引用
    /// </summary>
    public class Context
    {
		float[] x, y;
		PlotStrategyAbstract plts;	//strategy selected goes here
		//-----
		public void plot()
        {
			readFile();		//read in data
			plts.plot(x, y);//根据具体的策略对象，调用其算法的方法
		}
		/// <summary>
		/// 策略模式和简单工厂模式相结合，选择具体实现的职责由Context承担
        /// 客户端只需和Context类交互即可，使得具体策略算法和客户端隔离
		/// </summary>
		/// <param name="PlotStr"></param>
		public Context(string PlotStr)
        {
			switch(PlotStr)
			{
				case "BarPlot":
					plts = new BarPlotStrategy();
					break;
				case "LinePlot":
					plts = new LinePlotStrategy();
					break;
			}
			
		}
		//-----
		//select line plot
		public void setLinePlot()
        {
			
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
