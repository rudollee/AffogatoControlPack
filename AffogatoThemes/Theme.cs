using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using AffogatoThemes.Models;

namespace AffogatoThemes
{
	public class Theme
	{
		private Palette Palette;
		private Form Parent;

		#region Buttons
		protected void ApplyThemeToButtons(IEnumerable<Control> buttons, Palette palette)
		{
			if (buttons is null || !buttons.Any()) return;

			foreach (Button button in buttons)
			{
				button.ForeColor = palette.FontBasic;
				button.BackColor = palette.Background;
				button.FlatStyle = FlatStyle.Flat;
				button.FlatAppearance.BorderSize = 0;
				button.FlatAppearance.CheckedBackColor = palette.BackgroundSelected;
				button.FlatAppearance.MouseOverBackColor = palette.BackgroundHover;
				button.FlatAppearance.MouseDownBackColor = palette.BackgroundClicked;
			}
		}

		private void ApplyThemeToButtons() => ApplyThemeToButtons(GetControls<Button>(Parent), this.Palette);
		#endregion

		#region TextBox
		protected void ApplyThemeToTextBoxes(IEnumerable<Control> textBoxes, Palette palette)
		{
			if (textBoxes is null || !textBoxes.Any()) return;

			foreach (TextBox box in textBoxes)
			{
				box.ForeColor = palette.FontBasic;
				box.BackColor = palette.Background;
				box.BorderStyle = BorderStyle.FixedSingle;
			}
		}

		private void ApplyThemeToTextBoxes() => ApplyThemeToTextBoxes(GetControls<TextBox>(Parent), this.Palette);
		#endregion

		#region Combobox
		protected void ApplyThemeToCombobox(IEnumerable<Control> comboboxes, Palette palette)
		{
			if (comboboxes is null || !comboboxes.Any()) return;

			foreach (ComboBox combo in comboboxes)
			{
				combo.ForeColor = palette.FontBasic;
				combo.BackColor = palette.Background;
				combo.FlatStyle = FlatStyle.Flat;
				combo.DropDownStyle = ComboBoxStyle.DropDownList;
			}
		}

		private void ApplyThemeToCombobox() => ApplyThemeToCombobox(GetControls<ComboBox>(Parent), this.Palette);
		#endregion

		#region ListView
		protected void ApplyThemeToListView(IEnumerable<Control> listViews, Palette palette)
		{
			if (listViews is null || !listViews.Any()) return;

			foreach (ListView view in listViews)
			{
				view.ForeColor = palette.FontBasic;
				view.BackColor = palette.Background;
				view.BorderStyle = BorderStyle.None;
				view.View = View.Details;
				view.GridLines = true;

				foreach (ListViewItem item in view.SelectedItems)
				{
					item.BackColor = palette.BackgroundSelected;
					item.ForeColor = palette.FontSelected;
				}
			}
		}

		private void ApplyThemeToListView() => ApplyThemeToListView(this.GetControls<ListView>(Parent), this.Palette);
		#endregion

		#region GridView
		protected void ApplyThemeToGridview(IEnumerable<Control> views, Palette palette)
		{
			if (views is null || !views.Any()) return;

			foreach (DataGridView view in views)
			{
				view.Font = new Font("Verdana", 8.5F, GraphicsUnit.Point);
				view.ForeColor = palette.FontBasic;
				view.BackgroundColor = palette.Background;
				view.EnableHeadersVisualStyles = false;
				view.BorderStyle = BorderStyle.None;
				view.GridColor = palette.Border;
				view.RowHeadersVisible = false;
				view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

				view.DefaultCellStyle.BackColor = palette.Background;
				view.DefaultCellStyle.SelectionBackColor = palette.BackgroundSelected;
				view.DefaultCellStyle.SelectionForeColor = palette.FontSelected;
				view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
				view.DefaultCellStyle.Padding = new Padding(3, 0, 3, 3);

				view.ColumnHeadersDefaultCellStyle.BackColor = palette.BackgroundAlt;
				view.ColumnHeadersDefaultCellStyle.ForeColor = palette.FontBasic;
				view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				view.ColumnHeadersDefaultCellStyle.SelectionBackColor = palette.BackgroundAlt;
				view.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
				view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
				view.ColumnHeadersHeight = 30;
				view.RowTemplate.Height = 30;
				view.RowTemplate.Resizable = DataGridViewTriState.False;
				view.ScrollBars = ScrollBars.Vertical;

				foreach (DataGridViewColumn col in view.Columns)
				{
					col.SortMode = DataGridViewColumnSortMode.NotSortable;
					col.Resizable = DataGridViewTriState.False;
					col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				}

			}
		}

		private void ApplyThemeToGridview() => ApplyThemeToGridview(GetControls<DataGridView>(Parent), Palette);
		#endregion

		#region
		protected void ApplyThemeToToolStrips(IEnumerable<Control> toolStrips, Palette palette)
		{
			if (toolStrips is null || !toolStrips.Any()) return;

			foreach (ToolStrip strip in toolStrips)
			{
				strip.BackColor = palette.BackgroundAlt;
				strip.ForeColor = palette.FontBasic;
			}
		}

		private void ApplyThemeToToolStrips() => ApplyThemeToToolStrips(this.GetControls<ToolStrip>(Parent), this.Palette);
		#endregion

		#region Form
		protected void ApplyThemeToForm(Form form, Palette palette)
		{
			this.Parent = form;
			this.Palette = palette;

			form.BackColor = palette.Background;
			form.ForeColor = palette.FontBasic;
		}
		#endregion

		#region Apply All Controls
		protected void ApplyThemeToAll(Form form, Palette palette)
		{
			this.Parent = form;
			this.Palette = palette;

			form.BackColor = palette.Background;
			form.ForeColor = palette.FontBasic;

			ApplyThemeToButtons();
			ApplyThemeToTextBoxes();
			ApplyThemeToCombobox();
			ApplyThemeToListView();
			ApplyThemeToGridview();
			ApplyThemeToToolStrips();
		}
		#endregion

		#region Get Controls
		private IEnumerable<Control> GetControls<T>(Control parent) where T : Control
		{
			var ctrls = new List<Control>();
			foreach (Control child in parent.Controls)
			{
				ctrls.AddRange(GetControls<T>(child));
			}

			ctrls.Add(parent);
			return ctrls.Where(p => p.GetType() == typeof(T));
		}
		#endregion
	}
}
