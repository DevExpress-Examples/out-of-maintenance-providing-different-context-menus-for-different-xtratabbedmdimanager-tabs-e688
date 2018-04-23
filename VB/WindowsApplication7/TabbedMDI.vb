Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace WindowsApplication7
	Partial Public Class frmTabbedMDI
		Inherits DevExpress.XtraEditors.XtraForm
		Private helper As MenuHelper

		Public Sub New()
			InitializeComponent()
			For i As Integer = 0 To 2
				AddNewForm()
			Next i
			helper = New MenuHelper(xtraTabbedMdiManager1)
			AddHandler helper.PopupMenuShowing, AddressOf OnTabHeaderPopupMenuShowing
		End Sub
		'NEW EVENT
		Private Sub OnTabHeaderPopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
			If e.TabPage.Text.EndsWith("0") Then
				e.Menu.Items.Add(New DXMenuItem("Item 0"))
			End If
			If e.TabPage.Text.EndsWith("1") Then
				e.Menu.Items.Add(New DXMenuItem("Item 1"))
			End If
			If e.TabPage.Text.EndsWith("2") Then
				e.Menu.Items.Add(New DXMenuItem("Item 2"))
			End If
		End Sub
		Private formCount As Integer = 0
		Private Sub AddNewForm()
			Dim frm As New XtraForm()
			frm.Text = String.Format("Form {0}", formCount)
			formCount += 1
			frm.MdiParent = Me
			frm.Show()
		End Sub
		Private Sub xtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles xtraTabbedMdiManager1.PageAdded
			e.Page.Image = imageList1.Images(formCount Mod imageList1.Images.Count)
		End Sub
		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			RemoveHandler helper.PopupMenuShowing, AddressOf OnTabHeaderPopupMenuShowing
		End Sub
	End Class
End Namespace