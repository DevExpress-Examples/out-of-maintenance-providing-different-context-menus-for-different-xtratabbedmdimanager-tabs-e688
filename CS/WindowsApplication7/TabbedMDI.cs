using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace WindowsApplication7 {
    public partial class frmTabbedMDI : DevExpress.XtraEditors.XtraForm {
        MenuHelper helper;

        public frmTabbedMDI() {
            InitializeComponent();
            for(int i = 0; i < 3; i++) AddNewForm();
            helper = new MenuHelper(xtraTabbedMdiManager1);
            helper.PopupMenuShowing += OnTabHeaderPopupMenuShowing;
        }
        //NEW EVENT
        void OnTabHeaderPopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.TabPage.Text.EndsWith("0"))
                e.Menu.Items.Add(new DXMenuItem("Item 0"));
            if(e.TabPage.Text.EndsWith("1"))
                e.Menu.Items.Add(new DXMenuItem("Item 1"));
            if(e.TabPage.Text.EndsWith("2"))
                e.Menu.Items.Add(new DXMenuItem("Item 2"));
        }
        int formCount = 0;
        void AddNewForm() {
            XtraForm frm = new XtraForm();
            frm.Text = string.Format("Form {0}", formCount++);
            frm.MdiParent = this;
            frm.Show();
        }
        void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e) {
            e.Page.Image = imageList1.Images[formCount % imageList1.Images.Count];
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            helper.PopupMenuShowing -= OnTabHeaderPopupMenuShowing;
        }
    }
}