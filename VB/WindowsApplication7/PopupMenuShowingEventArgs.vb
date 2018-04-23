Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraTab

Namespace WindowsApplication7
	Public Delegate Sub PopupMenuShowingEventHandler(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)

	Public Class PopupMenuShowingEventArgs
		Inherits EventArgs
		Private tabPageCore As IXtraTabPage
		Private menuCore As DXPopupMenu

		Public Sub New(ByVal tabPage As IXtraTabPage)
			tabPageCore = tabPage
		End Sub
		Public Property Menu() As DXPopupMenu
			Get
				Return menuCore
			End Get
			Set(ByVal value As DXPopupMenu)
				menuCore = value
			End Set
		End Property
		Public ReadOnly Property TabPage() As IXtraTabPage
			Get
				Return tabPageCore
			End Get
		End Property
	End Class
End Namespace
