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
		private string? currentRepoName;
		public MainWindow()
		{
			InitializeComponent();

			MenuHandler handler = new MenuHandler();

			currentRepoName = GetCurrentRepositoryName();
			firstTab.Header = currentRepoName;
			handler.InitializeMenuButtons(btn_file, btn_view, btn_help, btn_tools);
		}
		/// TODO :: Initialize a repo then add to repos 
		private void OnViewClick(object s, RoutedEventArgs e)
		{
			//Clean Up
			var repo = new Repository(@"C:\Users\Ndiph\Documents\Git\WindowsPlatform\");
			var branches = repo.Branches;
			var name = repo.Branches.FirstOrDefault(b => b.FriendlyName == "develop");
			MessageBox.Show(name.FriendlyName);
			MessageBox.Show(name != null ? $"You are on the branch + {name.FriendlyName}" : name.FriendlyName);

			repo.Dispose();
		}
		private string GetCurrentRepositoryName()
		{
			string repoName = "NoName";
			try
			{
				using (var repo = new Repository(@"C:\Users\Ndiph\Documents\Git\GAME DEVELOPMENT\Unity-Traffic-System\"))
				{
					var repoPath = repo.Info.WorkingDirectory.TrimEnd(System.IO.Path.DirectorySeparatorChar);
					repoName = System.IO.Path.GetFileName(repoPath);
					lbl_response.Content = repoName;
				}
			}
			catch (RepositoryNotFoundException)
			{
				MessageBox.Show("No repository found.");
			}
			return repoName;
		}

		private void OnFileClick(object s, RoutedEventArgs e)
		{
			lbl_response.Content = "File tab clicked.";
		}
		private void OnOptionsClick(object s, RoutedEventArgs e)
		{
			lbl_response.Content = "Options tab clicked.";
		}
		private void OnHelpClick(object s, RoutedEventArgs e)
		{
			lbl_response.Content = "Help tab clicked.";
		}
		private void OnToolsClick(object s, RoutedEventArgs e)
		{
			lbl_response.Content = "Tools tab clicked.";
		}
		private void OnStageClick(object sender, RoutedEventArgs e)
		{
			lbl_response.Content = "Stage tab clicked.";
		}

		private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{

		}
	}
}