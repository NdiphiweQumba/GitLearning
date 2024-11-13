using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WindowsPlatform;
namespace WindowsPlatform.Menu
{

	internal class MenuHandler
	{
		public Action<string> OnButtonPress;
        public MenuHandler()
        {
			OnButtonPress = HandleMenuClick;
		}
		public void HandleMenuClick(string name) 
		{
			switch (name)
			{
				case "File":
					OnButtonPress("File");
					break;
				case "View":
					OnButtonPress("View");
					break;
				case "Help":
					OnButtonPress("Help");
					break;
				case "Tools":
					OnButtonPress("Tools");
					break;
				default:
					OnButtonPress("Not implemented button");
					break;
			}
		}
		public void InitializeMenuButtons(Button btn1, Button btn2, Button btn3, Button btn4)
		{
			//btn1.Click += (sender, e) =>	OnButtonPress("File");
			//btn2.Click += (sender, e) =>	OnButtonPress("View");
			//btn3.Click += (sender, e) =>	OnButtonPress("Help");
			//btn4.Click += (sender, e) =>	OnButtonPress("Tools");
		}
	}
}
