using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AffogatoControlPack
{
    public class ListViewEx : ListView
    {
        [DllImport("uxtheme", CharSet = CharSet.Auto)]
        static extern Boolean SetWindowTheme(IntPtr hWindow, String subAppName, String subIDList);

        public ListViewEx()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            SetWindowTheme(Handle, "explorer", null);
        }
    }
}
