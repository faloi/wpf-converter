using PropertyChanged;

namespace Converter.Domain
{
	[ImplementPropertyChanged]
	public class MilesConverter
	{
		public double Miles { get; set; }

		public double Kilometres { get; set; }

		public void Convert()
		{
			this.Kilometres = this.Miles * 1.60934;
		}
	}
}
