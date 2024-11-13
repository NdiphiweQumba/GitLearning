using LibGit2Sharp;
using System.Windows;
using WindowsPlatform.Menu;

namespace WindowsPlatform
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string? fetch;

		private object? ButtonSender;
		string? Name;
		public MainWindow()
		{
			InitializeComponent();
			MenuHandler handler = new MenuHandler();

			handler.InitializeMenuButtons(btn_file, btn_view, btn_help, btn_tools);
		}
		/// TODO :: Initialize a repo then add to repos 
		private void OnViewClick(object s, RoutedEventArgs e)
		{
			//Clean Up
			var repo = new Repository(@"C:\Users\Ndiph\Documents\Git\WindowsPlatform\");
			var branches = repo.Branches;
			var bname = repo.Branches.FirstOrDefault(b => b.FriendlyName == "develop");
			MessageBox.Show(bname.FriendlyName);
			MessageBox.Show(bname != null ? bname.FriendlyName: "notInitalized");

			repo.Dispose();
		}
		private void OnFileClick(object s, RoutedEventArgs e)
		{

		}
		private void OnToolsClick(object s, RoutedEventArgs e)
		{

		}
		private void OnHelpClick(object s, RoutedEventArgs e)
		{

		}

		private void OnClickViewFiles(object sender, RoutedEventArgs e)
		{

        }

		private void OnStageClick(object sender, RoutedEventArgs e)
		{

		}
	}
}