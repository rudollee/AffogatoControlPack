using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace AffogatoThemes.Models
{
	public class AffogatoColorTable : ProfessionalColorTable
	{
		public AffogatoColorTable()
		{
			base.UseSystemColors = false;
		}

        public override Color ToolStripBorder
        {
            get { return Color.Red; }
        }


        public override Color MenuBorder
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemSelected
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.LawnGreen; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.MediumSeaGreen; }
        }
        public override Color MenuStripGradientBegin
        {
            get { return Color.AliceBlue; }
        }
        public override Color MenuStripGradientEnd
        {
            get { return Color.Red; }
        }
    }
}
