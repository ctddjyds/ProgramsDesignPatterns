using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

/// <summary>
/// Summary description for ListChoice.
/// ConcreteBuilder
/// </summary>
/// creates a Panel containing a list box
public class ListChoiceBuilder:IChoiceBuilder
{
	private ArrayList stocks;
    private Panel m_productPanel;//product
    private ListBox list;
	//constructor creates and loads the list box
	public ListChoiceBuilder()
    {
		m_productPanel = new Panel ();
	}
	//returns the Panel
	public  Panel GetPanelResult()
    {
		return m_productPanel;
	}
	//returns an array of selected elements
	public ArrayList getSelected()
    {
		ArrayList sels = new ArrayList ();
		ListBox.SelectedObjectCollection  coll = list.SelectedItems;
		for(int i=0; i< coll.Count; i++)
        {
			string item = (string)coll[i];
				sels.Add (item );
		}
	    return sels;	
	}
	//clear selected elements
	public void Clear()
    { 
		list.Items.Clear();
	}
    /// <summary>
    /// ¹¹½¨Æ÷
    /// </summary>
    public void BuilderPanel()
    {
        list = new ListBox();
        list.Location = new Point(16, 0);
        list.Size = new Size(120, 160);
        list.SelectionMode = SelectionMode.MultiExtended;
        list.TabIndex = 0;
        m_productPanel.Controls.Add(list);
        for (int i = 0; i < stocks.Count; i++)
        {
            list.Items.Add(stocks[i]);
        }
    }

    public void BuilderArray(EquitiesAbstract equities)
    {
        stocks = equities.GetResult();
    }
}
