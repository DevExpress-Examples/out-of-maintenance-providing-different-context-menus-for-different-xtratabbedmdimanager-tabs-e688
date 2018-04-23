Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTabbedMdi

Namespace WindowsApplication7
	Public Class MenuHelper
		Private menuCore As DXPopupMenu
		Private managerCore As XtraTabbedMdiManager
		Public Event PopupMenuShowing As PopupMenuShowingEventHandler

		Public Sub New(ByVal manager As XtraTabbedMdiManager)
			Me.managerCore = manager
			AddHandler Me.managerCore.MouseUp, AddressOf OnManagerMouseUp
		End Sub
		Public Property Menu() As DXPopupMenu
			Get
				If menuCore Is Nothing Then
					menuCore = New DXPopupMenu()
				End If
				Return menuCore
			End Get
			Set(ByVal value As DXPopupMenu)
				menuCore = value
			End Set
		End Property
		Private Sub OnManagerMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button <> MouseButtons.Right Then
				Return
			End If
			Dim hi As BaseTabHitInfo = managerCore.CalcHitInfo(New Point(e.X, e.Y))
			If hi.HitTest = XtraTabHitTest.PageHeader Then
				Menu.Items.Clear()
				Dim args As New PopupMenuShowingEventArgs(hi.Page) With {.Menu = Menu}
				RaisePopupMenuShowing(args)
				CType(Menu, IDXDropDownControl).Show(New SkinMenuManager(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel), managerCore.MdiParent.ActiveMdiChild, e.Location)

			End If
		End Sub
		Private Sub RaisePopupMenuShowing(ByVal e As PopupMenuShowingEventArgs)
			RaiseEvent PopupMenuShowing(managerCore, e)
		End Sub
	End Class
End Namespace
