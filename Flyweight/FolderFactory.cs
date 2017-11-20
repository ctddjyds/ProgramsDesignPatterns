using System;
using System.Drawing ;
namespace Flyweight
{
    /// <summary>
    /// Summary description for FolderFactory.
    /// 享元工厂，负责创建和管理享元对象
    /// </summary>
    public class FolderFactory
    {
		private Folder selFolder, unselFolder;
		//-----
		public FolderFactory()
        {
			//create the two folders
			selFolder = new Folder(Color.Brown);
			unselFolder = new Folder(Color.Bisque);
		}
		//-----
		public Folder getFolder(bool selected)
        {
			if(selected)
				return selFolder;
			else
				return unselFolder;
		}
	}
}
