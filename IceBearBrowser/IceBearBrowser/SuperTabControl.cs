using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IceBearBrowser
{
    class SuperTabControl : TabControl
    {
        private Point _lastClickPos;
        private ContextMenuStrip _CMS;

        public SuperTabControl()
        {
            _CMS = GetCMS();
        }

        private ContextMenuStrip GetCMS()
        {
            ContextMenuStrip CMS = new ContextMenuStrip();
            CMS.Items.Add("Close", null, new EventHandler(Item_Clicked));
            return _CMS;
        }

        private void Item_Clicked(Object sender, EventArgs e)
        {
            for (int i = 0; i < this.TabCount; i++)
            {
                Rectangle rect = this.GetTabRect(i);
                if(rect.Contains(this.PointToClient(Cursor.Position)))
                {
                    this.TabPages.RemoveAt(i);
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                _CMS.Show(Cursor.Position);
            }
        }
    }
}
