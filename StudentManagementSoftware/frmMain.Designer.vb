<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        BarManager1 = New DevExpress.XtraBars.BarManager(components)
        Bar1 = New DevExpress.XtraBars.Bar()
        menu = New DevExpress.XtraBars.BarSubItem()
        itemStudentList = New DevExpress.XtraBars.BarButtonItem()
        Bar3 = New DevExpress.XtraBars.Bar()
        barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(BarManager1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BarManager1
        ' 
        BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Bar1, Bar3})
        BarManager1.DockControls.Add(barDockControlTop)
        BarManager1.DockControls.Add(barDockControlBottom)
        BarManager1.DockControls.Add(barDockControlLeft)
        BarManager1.DockControls.Add(barDockControlRight)
        BarManager1.Form = Me
        BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarButtonItem1, menu, itemStudentList})
        BarManager1.MaxItemId = 3
        BarManager1.StatusBar = Bar3
        ' 
        ' Bar1
        ' 
        Bar1.BarName = "Tools"
        Bar1.DockCol = 0
        Bar1.DockRow = 0
        Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, menu, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Bar1.Text = "Tools"
        ' 
        ' menu
        ' 
        menu.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        menu.Caption = "Menu"
        menu.Id = 1
        menu.ImageOptions.Image = CType(resources.GetObject("menu.ImageOptions.Image"), Image)
        menu.ImageOptions.LargeImage = CType(resources.GetObject("menu.ImageOptions.LargeImage"), Image)
        menu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, itemStudentList, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        menu.Name = "menu"
        ' 
        ' itemStudentList
        ' 
        itemStudentList.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        itemStudentList.Caption = "Student list"
        itemStudentList.Id = 2
        itemStudentList.ImageOptions.Image = CType(resources.GetObject("itemStudentList.ImageOptions.Image"), Image)
        itemStudentList.ImageOptions.LargeImage = CType(resources.GetObject("itemStudentList.ImageOptions.LargeImage"), Image)
        itemStudentList.Name = "itemStudentList"
        ' 
        ' Bar3
        ' 
        Bar3.BarName = "Status bar"
        Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Bar3.DockCol = 0
        Bar3.DockRow = 0
        Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Bar3.OptionsBar.AllowQuickCustomization = False
        Bar3.OptionsBar.DrawDragBorder = False
        Bar3.OptionsBar.UseWholeRow = True
        Bar3.Text = "Status bar"
        ' 
        ' barDockControlTop
        ' 
        barDockControlTop.CausesValidation = False
        barDockControlTop.Dock = DockStyle.Top
        barDockControlTop.Location = New Point(0, 0)
        barDockControlTop.Manager = BarManager1
        barDockControlTop.Size = New Size(800, 32)
        ' 
        ' barDockControlBottom
        ' 
        barDockControlBottom.CausesValidation = False
        barDockControlBottom.Dock = DockStyle.Bottom
        barDockControlBottom.Location = New Point(0, 430)
        barDockControlBottom.Manager = BarManager1
        barDockControlBottom.Size = New Size(800, 20)
        ' 
        ' barDockControlLeft
        ' 
        barDockControlLeft.CausesValidation = False
        barDockControlLeft.Dock = DockStyle.Left
        barDockControlLeft.Location = New Point(0, 32)
        barDockControlLeft.Manager = BarManager1
        barDockControlLeft.Size = New Size(0, 398)
        ' 
        ' barDockControlRight
        ' 
        barDockControlRight.CausesValidation = False
        barDockControlRight.Dock = DockStyle.Right
        barDockControlRight.Location = New Point(800, 32)
        barDockControlRight.Manager = BarManager1
        barDockControlRight.Size = New Size(0, 398)
        ' 
        ' BarButtonItem1
        ' 
        BarButtonItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        BarButtonItem1.Caption = "Menu"
        BarButtonItem1.Id = 0
        BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), Image)
        BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), Image)
        BarButtonItem1.Name = "BarButtonItem1"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(barDockControlLeft)
        Controls.Add(barDockControlRight)
        Controls.Add(barDockControlBottom)
        Controls.Add(barDockControlTop)
        Name = "frmMain"
        Text = "Student Management Software"
        CType(BarManager1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents menu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents itemStudentList As DevExpress.XtraBars.BarButtonItem

End Class
