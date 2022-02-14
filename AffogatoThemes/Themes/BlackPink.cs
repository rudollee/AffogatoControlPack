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
				Background = Color.FromArgb(25, 25, 25),
				BackgroundAlt = Color.FromArgb(30, 30, 30),
				BackgroundSelected = Color.FromArgb(30, 30, 30),
				BackgroundHover = Color.Gray,
				BackgroundClicked = Color.LightGray,
				Border = Color.FromArgb(30, 30, 30),
				Grid = Color.FromArgb(30, 30, 30)
			};

			if (form != null) ApplyThemeToAll(form, palette);

        }
    }
}
