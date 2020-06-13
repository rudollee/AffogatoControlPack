using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffogatoControlPack
{
    /// <summary>
    /// references : https://stackoverflow.com/questions/34877280/change-combobox-border-color-in-windows-forms
    /// </summary>
    public class ComboBoxEx : ComboBox
    {
        [Category("Appearance")]
        [Description("Border Color")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color BorderColor { get; set; } = Color.Gray;

        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (DropDownStyle == ComboBoxStyle.Simple) return;
            if (m.Msg != WM_PAINT) return;

            using (var g = Graphics.FromHwnd(Handle))
            {
                using (var p = new Pen(BorderColor))
                {
                    g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);

                    var d = FlatStyle == FlatStyle.Popup ? 1 : 0;
                    g.DrawLine(p, Width - buttonWidth - d, 0, Width - buttonWidth - d, Height);
                }
            }
        }
    }
}
