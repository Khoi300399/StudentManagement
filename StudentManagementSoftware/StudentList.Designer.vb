<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentList))
        BarManager1 = New DevExpress.XtraBars.BarManager(components)
        Bar1 = New DevExpress.XtraBars.Bar()
        btnNew = New DevExpress.XtraBars.BarButtonItem()
        btnDelete = New DevExpress.XtraBars.BarButtonItem()
        btnExport = New DevExpress.XtraBars.BarButtonItem()
        Bar3 = New DevExpress.XtraBars.Bar()
        barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        grid = New DevExpress.XtraGrid.GridControl()
        detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        fullname = New DevExpress.XtraGrid.Columns.GridColumn()
        email = New DevExpress.XtraGrid.Columns.GridColumn()
        birthday = New DevExpress.XtraGrid.Columns.GridColumn()
        phone = New DevExpress.XtraGrid.Columns.GridColumn()
        address = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(BarManager1, ComponentModel.ISupportInitialize).BeginInit()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        CType(detail, ComponentModel.ISupportInitialize).BeginInit()
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
        BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {btnNew, btnDelete, btnExport})
        BarManager1.MaxItemId = 3
        BarManager1.StatusBar = Bar3
        ' 
        ' Bar1
        ' 
        Bar1.BarName = "Tools"
        Bar1.DockCol = 0
        Bar1.DockRow = 0
        Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnNew, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDelete, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnExport, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Bar1.Text = "Tools"
        ' 
        ' btnNew
        ' 
        btnNew.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnNew.Caption = "Add"
        btnNew.Id = 0
        btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), Image)
        btnNew.ImageOptions.LargeImage = CType(resources.GetObject("btnNew.ImageOptions.LargeImage"), Image)
        btnNew.Name = "btnNew"
        ' 
        ' btnDelete
        ' 
        btnDelete.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnDelete.Caption = "Delete"
        btnDelete.Id = 1
        btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), Image)
        btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), Image)
        btnDelete.Name = "btnDelete"
        ' 
        ' btnExport
        ' 
        btnExport.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnExport.Caption = "Export file"
        btnExport.Id = 2
        btnExport.ImageOptions.Image = CType(resources.GetObject("btnExport.ImageOptions.Image"), Image)
        btnExport.ImageOptions.LargeImage = CType(resources.GetObject("btnExport.ImageOptions.LargeImage"), Image)
        btnExport.Name = "btnExport"
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
        barDockControlTop.Size = New Size(638, 32)
        ' 
        ' barDockControlBottom
        ' 
        barDockControlBottom.CausesValidation = False
        barDockControlBottom.Dock = DockStyle.Bottom
        barDockControlBottom.Location = New Point(0, 463)
        barDockControlBottom.Manager = BarManager1
        barDockControlBottom.Size = New Size(638, 20)
        ' 
        ' barDockControlLeft
        ' 
        barDockControlLeft.CausesValidation = False
        barDockControlLeft.Dock = DockStyle.Left
        barDockControlLeft.Location = New Point(0, 32)
        barDockControlLeft.Manager = BarManager1
        barDockControlLeft.Size = New Size(0, 431)
        ' 
        ' barDockControlRight
        ' 
        barDockControlRight.CausesValidation = False
        barDockControlRight.Dock = DockStyle.Right
        barDockControlRight.Location = New Point(638, 32)
        barDockControlRight.Manager = BarManager1
        barDockControlRight.Size = New Size(0, 431)
        ' 
        ' grid
        ' 
        grid.Dock = DockStyle.Fill
        grid.Location = New Point(0, 32)
        grid.MainView = detail
        grid.MenuManager = BarManager1
        grid.Name = "grid"
        grid.Size = New Size(638, 431)
        grid.TabIndex = 4
        grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {detail})
        ' 
        ' detail
        ' 
        detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {fullname, email, birthday, phone, address})
        detail.GridControl = grid
        detail.Name = "detail"
        detail.OptionsView.ColumnAutoWidth = False
        detail.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True
        detail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        detail.OptionsView.ShowAutoFilterRow = True
        ' 
        ' fullname
        ' 
        fullname.Caption = "Full name"
        fullname.FieldName = "fullname"
        fullname.MinWidth = 25
        fullname.Name = "fullname"
        fullname.Visible = True
        fullname.VisibleIndex = 0
        fullname.Width = 94
        ' 
        ' email
        ' 
        email.Caption = "Email"
        email.FieldName = "email"
        email.MinWidth = 25
        email.Name = "email"
        email.Visible = True
        email.VisibleIndex = 1
        email.Width = 94
        ' 
        ' birthday
        ' 
        birthday.Caption = "Birthday"
        birthday.FieldName = "birthday"
        birthday.MinWidth = 25
        birthday.Name = "birthday"
        birthday.Visible = True
        birthday.VisibleIndex = 2
        birthday.Width = 94
        ' 
        ' phone
        ' 
        phone.Caption = "Phone Number"
        phone.FieldName = "phone"
        phone.MinWidth = 25
        phone.Name = "phone"
        phone.Visible = True
        phone.VisibleIndex = 3
        phone.Width = 94
        ' 
        ' address
        ' 
        address.Caption = "Address"
        address.FieldName = "address"
        address.MinWidth = 25
        address.Name = "address"
        address.Visible = True
        address.VisibleIndex = 4
        address.Width = 94
        ' 
        ' frmStudentList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(638, 483)
        Controls.Add(grid)
        Controls.Add(barDockControlLeft)
        Controls.Add(barDockControlRight)
        Controls.Add(barDockControlBottom)
        Controls.Add(barDockControlTop)
        Name = "frmStudentList"
        Text = "Student List"
        CType(BarManager1, ComponentModel.ISupportInitialize).EndInit()
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        CType(detail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents birthday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents phone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents address As DevExpress.XtraGrid.Columns.GridColumn
End Class
