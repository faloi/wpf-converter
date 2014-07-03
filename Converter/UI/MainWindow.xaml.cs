using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Converter.Domain;

namespace Converter.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MilesConverter Model { get { return (this.DataContext as MilesConverter); } }

		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = new MilesConverter { Miles = 100 };
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Model.Convert();
		}
	}
}
