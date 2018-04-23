using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTabbedMdi;

namespace WindowsApplication7 {
    public class MenuHelper {
        DXPopupMenu menuCore;
        XtraTabbedMdiManager managerCore;
        public event PopupMenuShowingEventHandler PopupMenuShowing;

        public MenuHelper(XtraTabbedMdiManager manager) {
            this.managerCore = manager;
            this.managerCore.MouseUp += OnManagerMouseUp;
        }
        public DXPopupMenu Menu {
            get {
                if(menuCore == null)
                    menuCore = new DXPopupMenu();
                return menuCore;
            }
            set { menuCore = value; }
        }
        void OnManagerMouseUp(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Right)
                return;
            BaseTabHitInfo hi = managerCore.CalcHitInfo(new Point(e.X, e.Y));
            if(hi.HitTest == XtraTabHitTest.PageHeader) {
                Menu.Items.Clear();
                PopupMenuShowingEventArgs args = new PopupMenuShowingEventArgs(hi.Page) { Menu = Menu };
                RaisePopupMenuShowing(args);
                ((IDXDropDownControl)Menu).Show(new SkinMenuManager(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel),
                   managerCore.MdiParent.ActiveMdiChild,
                   e.Location);

            }
        }
        void RaisePopupMenuShowing(PopupMenuShowingEventArgs e) {
            if(PopupMenuShowing != null)
                PopupMenuShowing(managerCore, e);
        }
    }
}
