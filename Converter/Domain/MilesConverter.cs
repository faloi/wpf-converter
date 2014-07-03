using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Domain
{
	public class MilesConverter : INotifyPropertyChanged
	{
		private double kilometres;
		public double Miles { get; set; }

		public double Kilometres
		{
			get { return kilometres; }
			set { kilometres = value; OnPropertyChanged(); }
		}

		public void Convert()
		{
			this.Kilometres = this.Miles * 1.60934;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
