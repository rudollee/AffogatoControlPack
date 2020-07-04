using System.Drawing;
using System.Windows.Forms;

namespace AffogatoControlPack
{
	public class ToolStripMenuItemRenderer : ToolStripProfessionalRenderer
	{
		private Color Background;
		private Color BackgroundSelected;
		public ToolStripMenuItemRenderer(Color background, Color backgroundSelected)
		{
			this.Background = background;
			this.BackgroundSelected = backgroundSelected;
		}

		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			var rectangle = new Rectangle(Point.Empty, e.Item.Size);
			var c = e.Item.Selected ? BackgroundSelected : Background;
			using (var brush = new SolidBrush(c))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}
	}
}
