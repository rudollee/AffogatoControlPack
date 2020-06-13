using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AffogatoControlPack
{
    public class ListViewEx : ListView
    {
        private int focusedItemIndex;

        [Category("Appearance")]
        [Description("Border Color")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color GridColor { get; set; } = Color.Gray;

        [Category("Appearance")]
        [Description("Back Color of Selected Item ")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color BackColorItemSelected { get; set; } = Color.Black;

        [Category("Appearance")]
        [Description("Fore Color of Selected Item ")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color ForeColorItemSelected { get; set; } = Color.Pink;

        [DllImport("uxtheme", CharSet = CharSet.Auto)]
        static extern Boolean SetWindowTheme(IntPtr hWindow, String subAppName, String subIDList);

        public ListViewEx()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);

            DrawColumnHeader += ListViewEx_DrawColumnHeader;
            DrawItem += ListViewEx_DrawItem;
            Leave += ListViewEx_Leave;
        }

        private void ListViewEx_Leave(object sender, EventArgs e)
        {
            focusedItemIndex = (sender as ListViewEx).FocusedItem.Index;
        }

        private void ListViewEx_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

            var lv = sender as ListViewEx;
            if (!e.Item.Selected)
            {
                if (focusedItemIndex == e.Item.Index)
                {
                    e.Item.ForeColor = ForeColorItemSelected;
                    e.Item.BackColor = BackColorItemSelected;

                    focusedItemIndex = -1;
                }
                else if (lv.Focused)
                {
                    e.Item.ForeColor = ForeColorItemSelected;
                    e.Item.BackColor = BackColor;
                }
                else if (lv.HoverSelection)
                {
                    e.Item.ForeColor = ForeColorItemSelected;
                }
            }
            else
            {
                e.Item.ForeColor = ForeColor;
                e.Item.BackColor = BackColor;
            }

            e.DrawDefault = true;
        }

        private void ListViewEx_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            var backcolor = new SolidBrush(GridColor);
            var forecolor = new SolidBrush(ForeColor);
            e.Graphics.FillRectangle(backcolor, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, e.Font, forecolor, e.Bounds);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            SetWindowTheme(Handle, "explorer", null);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case 0xf:
                    if (View != View.Details) return;
                    if (!GridLines) return;
                    if (Items.Count == 0) return;

                    using (var g = CreateGraphics())
                    {
                        using (var pen = new Pen(GridColor))
                        {
                            int w = 0;
                            for (int c = 0; c < Columns.Count; c++)
                            {
                                w += Columns[c].Width;
                                g.DrawLine(pen, new Point(w, 0), new Point(w, ClientSize.Height));
                            }

                            int firstItem = Items[0].Bounds.Bottom - 1;
                            int itemHeight = Items[0].Bounds.Height;
                            for (int r = firstItem; r < Height; r+= itemHeight)
                            {
                                g.DrawLine(pen, new Point(0, r), new Point(ClientSize.Width, r));
                            }
                        }
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
