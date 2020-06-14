using AffogatoThemes.Models;
using System.Drawing;

using System.Windows.Forms;

namespace AffogatoThemes.Themes
{
    public class Affogato : Theme
    {
        public Affogato(Form form)
        {
			var palette = new Palette()
			{
				FontBasic = Color.FromArgb(150, 150, 150),
				FontAlt = Color.FromArgb(150, 150, 150),
				FontSelected = Color.FromArgb(160, 140, 140),
				Background = Color.FromArgb(35, 30, 30),
				BackgroundAlt = Color.FromArgb(40, 35, 35),
				BackgroundSelected = Color.FromArgb(40, 35, 35),
				BackgroundHover = Color.Gray,
				BackgroundClicked = Color.LightGray,
				Border = Color.FromArgb(40, 35, 35),
				Grid = Color.FromArgb(40, 35, 35)
			};

			if (form != null) ApplyThemeToAll(form, palette);

		}
	}
}
