using Microsoft.Maui.Graphics.Converters;

namespace ColorTypeConverterRepro
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			ColorTypeConverter colorTypeConverter = new();

			// rgba = 0,0,0,0
			Color color = Colors.Transparent;

			// #000000, the alpha channel is dropped
			string? colorAsString = colorTypeConverter.ConvertToInvariantString(color);

			// rgba = 0,0,0,1, the color has changed
			Color backToColor = (Color)colorTypeConverter.ConvertFromInvariantString(colorAsString);

			Color1.Text = color.ToRgbaHex();
			Color1.BackgroundColor = color;

			Color2.Text = backToColor.ToRgbaHex();
			Color2.BackgroundColor = backToColor;
		}
	}

}
