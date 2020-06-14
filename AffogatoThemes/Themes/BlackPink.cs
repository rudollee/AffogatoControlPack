using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using AffogatoThemes.Models;

namespace AffogatoThemes.Themes
{
    public class BlackPink : Theme
    {
        public BlackPink(Form form)
        {
            var palette = new Palette()
            {
				FontBasic = Color.FromArgb(150, 150, 150),
				FontAlt = Color.FromArgb(150, 150, 150),
				FontSelected = Color.FromArgb(160, 140, 160),
				Background = Color.FromArgb(35, 30, 35),
				BackgroundAlt = Color.FromArgb(40, 35, 40),
				BackgroundSelected = Color.FromArgb(40, 35, 40),
				BackgroundHover = Color.Gray,
				BackgroundClicked = Color.LightGray,
				Border = Color.FromArgb(40, 35, 40),
				Grid = Color.FromArgb(40, 35, 40)
			};

			if (form != null) ApplyThemeToAll(form, palette);

        }
    }
}
