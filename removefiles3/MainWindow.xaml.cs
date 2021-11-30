using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace removefiles3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				var files = Directory.EnumerateFiles(DirectoryPath.Text);
				Files.Text = "";
				foreach (var file in files)
				{
					Files.Text += file + "\n";

				}
			}
			catch
			{
				Files.Text = "Invalid path";
			}
		}

		private void Button_Click2(object sender, RoutedEventArgs e)
		{
			try
			{
				var files = Directory.EnumerateFiles(DirectoryPath.Text);
				DeletedFiles.Text = "";
				foreach (var file in files)
				{
					if (file.EndsWith(".ok"))
					{
						File.Delete(file);
						DeletedFiles.Text += file + "\n";
					}
				}
			}
			catch
			{
				DeletedFiles.Text = "Invalid path";
			}
		}
	}
}
