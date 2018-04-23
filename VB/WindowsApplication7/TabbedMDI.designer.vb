Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars
Namespace WindowsApplication7
	Partial Public Class frmTabbedMDI
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' 
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmTabbedMDI))
			Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabbedMdiManager1
			' 
			Me.xtraTabbedMdiManager1.MdiParent = Me
'			Me.xtraTabbedMdiManager1.PageAdded += New DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(Me.xtraTabbedMdiManager1_PageAdded);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			' 
			' PopupMenu1
			' 
			Me.PopupMenu1.Name = "PopupMenu1"
			' 
			' frmTabbedMDI
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.ClientSize = New System.Drawing.Size(771, 310)
			Me.IsMdiContainer = True
			Me.Name = "frmTabbedMDI"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "TabbedMDI (C# code)"
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Friend PopupMenu1 As PopupMenu

	End Class
End Namespace
