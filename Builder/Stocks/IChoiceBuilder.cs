using System;
using System.Collections ;
using System.Windows.Forms;
/// <summary>
/// Summary description for MultiChoice.
/// builder
/// </summary>
public interface IChoiceBuilder
{
	ArrayList getSelected();
	void Clear();
    //getResult
	Panel GetPanelResult();
    //built part
    void BuilderPanel();
    void BuilderArray(EquitiesAbstract equities);
}

