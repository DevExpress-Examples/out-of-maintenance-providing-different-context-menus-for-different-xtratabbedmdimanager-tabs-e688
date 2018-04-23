using System;
using DevExpress.Utils.Menu;
using DevExpress.XtraTab;

namespace WindowsApplication7 {
    public delegate void PopupMenuShowingEventHandler(object sender, PopupMenuShowingEventArgs e);

    public class PopupMenuShowingEventArgs : EventArgs {
        IXtraTabPage tabPageCore;
        DXPopupMenu menuCore;

        public PopupMenuShowingEventArgs(IXtraTabPage tabPage) {
            tabPageCore = tabPage;
        }
        public DXPopupMenu Menu {
            get { return menuCore; }
            set { menuCore = value; }
        }
        public IXtraTabPage TabPage {
            get { return tabPageCore; }
        }
    }
}
