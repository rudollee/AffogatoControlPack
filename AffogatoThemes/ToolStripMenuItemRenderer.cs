using System.Drawing;
using System.Windows.Forms;

namespace AffogatoThemes
{
	public class ToolStripMenuItemRenderer : ToolStripProfessionalRenderer
	{
		private Color Background;
		private Color BackgroundSelected;
		private ProfessionalColorTable _professionalColorTable;
		public ToolStripMenuItemRenderer(Color background, Color backgroundSelected)
		{
			base.ColorTable.UseSystemColors = false;
			this.Background = background;
			this.BackgroundSelected = backgroundSelected;
		}

		public ToolStripMenuItemRenderer(ProfessionalColorTable colorTable )
		{
			_professionalColorTable = colorTable;
		}

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			//base.OnRenderToolStripBorder(e);
		}

		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			var rectangle = new Rectangle(Point.Empty, new Size(e.Item.Size.Width, e.Item.Size.Height));
			var c = e.Item.Selected ? BackgroundSelected : Background;
			using (var brush = new SolidBrush(c))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}

			//base.OnRenderMenuItemBackground(e);
			//if (e.Item.Enabled && e.Item.Selected)
			//{
			//	using (var pen = new Pen(((MyColorTable)ColorTable).MenuItemEnabledBorder))
			//	{
			//		var r = new Rectangle(2, 0, e.Item.Width - 4, e.Item.Height - 1);
			//		e.Graphics.DrawRectangle(pen, r);
			//	}
			//}
		}


	}

	public class MyColorTable : ProfessionalColorTable
	{
		public MyColorTable()
		{
			base.UseSystemColors = false;
		}

		public override Color MenuItemBorder { get { return Color.Transparent; } }
		public Color MenuItemEnabledBorder { get { return base.MenuItemBorder; } }
	}
}
