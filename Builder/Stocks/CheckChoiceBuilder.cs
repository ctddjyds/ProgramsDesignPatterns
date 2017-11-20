using System;
using System.Collections ;
using System.Windows.Forms ;
using System.Drawing ;

//returns a panel of 0 to 3 check boxes
/// <summary>
/// ConcreteBuilder
/// </summary>
public class CheckChoiceBuilder:IChoiceBuilder
{
	private ArrayList stocks;
	private Panel m_productPanel;//product
	private ArrayList boxes;

	public CheckChoiceBuilder()
    {
		m_productPanel = new Panel ();
	}

	//uncheck all check boxes
	public  void Clear()
    {
		for(int i=0; i< boxes.Count; i++)
        {
			CheckBox ck = (CheckBox)boxes[i];
			ck.Checked =false;
		}
	}

	//return list of checked items
	public ArrayList getSelected()
    {
		ArrayList sels = new ArrayList ();
		for(int i=0; i< boxes.Count ; i++)
        {
			CheckBox ck = (CheckBox)boxes[i];
			if (ck.Checked )
            {
				sels.Add (ck.Text );
			}
		}
		return sels;
	}

	//return panel of checkboxes
	public Panel GetPanelResult()
    {
		return m_productPanel;
	}

    public void BuilderPanel()
    {
        boxes = new ArrayList();
        //add the check boxes to the panel
        for (int i = 0; i < stocks.Count; i++)
        {
            CheckBox ck = new CheckBox();
            //position them
            ck.Location = new Point(8, 16 + i * 32);
            string stk = (string)stocks[i];
            ck.Text = stk;
            ck.Size = new Size(112, 24);
            ck.TabIndex = 0;
            ck.TextAlign = ContentAlignment.MiddleLeft;
            boxes.Add(ck);
            m_productPanel.Controls.Add(ck);
        }
    }

    public void BuilderArray(EquitiesAbstract equities)
    {
        stocks = equities.GetResult();
    }
}
