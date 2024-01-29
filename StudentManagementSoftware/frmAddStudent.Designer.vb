<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStudent))
        lblFullname = New DevExpress.XtraEditors.LabelControl()
        lblEmail = New DevExpress.XtraEditors.LabelControl()
        lblPhone = New DevExpress.XtraEditors.LabelControl()
        lblBirthday = New DevExpress.XtraEditors.LabelControl()
        lblAddress = New DevExpress.XtraEditors.LabelControl()
        txtFullname = New DevExpress.XtraEditors.TextEdit()
        txtEmail = New DevExpress.XtraEditors.TextEdit()
        txtPhone = New DevExpress.XtraEditors.TextEdit()
        txtAddress = New DevExpress.XtraEditors.TextEdit()
        BarManager1 = New DevExpress.XtraBars.BarManager(components)
        Bar1 = New DevExpress.XtraBars.Bar()
        btnSave = New DevExpress.XtraBars.BarButtonItem()
        btnReset = New DevExpress.XtraBars.BarButtonItem()
        barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        txtBirthday = New DevExpress.XtraEditors.DateEdit()
        CType(txtFullname.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtEmail.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtPhone.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtAddress.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(BarManager1, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtBirthday.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtBirthday.Properties.CalendarTimeProperties, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFullname
        ' 
        lblFullname.Appearance.Font = New Font("Times New Roman", 12F)
        lblFullname.Appearance.Options.UseFont = True
        lblFullname.Location = New Point(29, 68)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(78, 22)
        lblFullname.TabIndex = 0
        lblFullname.Text = "Full name"
        ' 
        ' lblEmail
        ' 
        lblEmail.Appearance.Font = New Font("Times New Roman", 12F)
        lblEmail.Appearance.Options.UseFont = True
        lblEmail.Location = New Point(29, 112)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(47, 22)
        lblEmail.TabIndex = 0
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.Appearance.Font = New Font("Times New Roman", 12F)
        lblPhone.Appearance.Options.UseFont = True
        lblPhone.Location = New Point(29, 213)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(112, 22)
        lblPhone.TabIndex = 0
        lblPhone.Text = "Phone number"
        ' 
        ' lblBirthday
        ' 
        lblBirthday.Appearance.Font = New Font("Times New Roman", 12F)
        lblBirthday.Appearance.Options.UseFont = True
        lblBirthday.Location = New Point(29, 160)
        lblBirthday.Name = "lblBirthday"
        lblBirthday.Size = New Size(68, 22)
        lblBirthday.TabIndex = 0
        lblBirthday.Text = "Birthday"
        ' 
        ' lblAddress
        ' 
        lblAddress.Appearance.Font = New Font("Times New Roman", 12F)
        lblAddress.Appearance.Options.UseFont = True
        lblAddress.Location = New Point(29, 269)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(66, 22)
        lblAddress.TabIndex = 0
        lblAddress.Text = "Address"
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(163, 62)
        txtFullname.Name = "txtFullname"
        txtFullname.Properties.Appearance.Font = New Font("Times New Roman", 12F)
        txtFullname.Properties.Appearance.Options.UseFont = True
        txtFullname.Size = New Size(275, 28)
        txtFullname.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(163, 106)
        txtEmail.Name = "txtEmail"
        txtEmail.Properties.Appearance.Font = New Font("Times New Roman", 12F)
        txtEmail.Properties.Appearance.Options.UseFont = True
        txtEmail.Size = New Size(275, 28)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(163, 207)
        txtPhone.Name = "txtPhone"
        txtPhone.Properties.Appearance.Font = New Font("Times New Roman", 12F)
        txtPhone.Properties.Appearance.Options.UseFont = True
        txtPhone.Size = New Size(186, 28)
        txtPhone.TabIndex = 1
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(163, 263)
        txtAddress.Name = "txtAddress"
        txtAddress.Properties.Appearance.Font = New Font("Times New Roman", 12F)
        txtAddress.Properties.Appearance.Options.UseFont = True
        txtAddress.Size = New Size(448, 28)
        txtAddress.TabIndex = 1
        ' 
        ' BarManager1
        ' 
        BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Bar1})
        BarManager1.DockControls.Add(barDockControlTop)
        BarManager1.DockControls.Add(barDockControlBottom)
        BarManager1.DockControls.Add(barDockControlLeft)
        BarManager1.DockControls.Add(barDockControlRight)
        BarManager1.Form = Me
        BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {btnSave, btnReset})
        BarManager1.MaxItemId = 2
        ' 
        ' Bar1
        ' 
        Bar1.BarName = "Tools"
        Bar1.DockCol = 0
        Bar1.DockRow = 0
        Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnSave, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnReset, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Bar1.Text = "Tools"
        ' 
        ' btnSave
        ' 
        btnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnSave.Caption = "Save"
        btnSave.Id = 0
        btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), Image)
        btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), Image)
        btnSave.Name = "btnSave"
        ' 
        ' btnReset
        ' 
        btnReset.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        btnReset.Caption = "Reset"
        btnReset.Id = 1
        btnReset.ImageOptions.Image = CType(resources.GetObject("btnReset.ImageOptions.Image"), Image)
        btnReset.ImageOptions.LargeImage = CType(resources.GetObject("btnReset.ImageOptions.LargeImage"), Image)
        btnReset.Name = "btnReset"
        ' 
        ' barDockControlTop
        ' 
        barDockControlTop.CausesValidation = False
        barDockControlTop.Dock = DockStyle.Top
        barDockControlTop.Location = New Point(0, 0)
        barDockControlTop.Manager = BarManager1
        barDockControlTop.Size = New Size(650, 32)
        ' 
        ' barDockControlBottom
        ' 
        barDockControlBottom.CausesValidation = False
        barDockControlBottom.Dock = DockStyle.Bottom
        barDockControlBottom.Location = New Point(0, 334)
        barDockControlBottom.Manager = BarManager1
        barDockControlBottom.Size = New Size(650, 0)
        ' 
        ' barDockControlLeft
        ' 
        barDockControlLeft.CausesValidation = False
        barDockControlLeft.Dock = DockStyle.Left
        barDockControlLeft.Location = New Point(0, 32)
        barDockControlLeft.Manager = BarManager1
        barDockControlLeft.Size = New Size(0, 302)
        ' 
        ' barDockControlRight
        ' 
        barDockControlRight.CausesValidation = False
        barDockControlRight.Dock = DockStyle.Right
        barDockControlRight.Location = New Point(650, 32)
        barDockControlRight.Manager = BarManager1
        barDockControlRight.Size = New Size(0, 302)
        ' 
        ' txtBirthday
        ' 
        txtBirthday.EditValue = Nothing
        txtBirthday.Location = New Point(163, 152)
        txtBirthday.MenuManager = BarManager1
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Properties.Appearance.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBirthday.Properties.Appearance.Options.UseFont = True
        txtBirthday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        txtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        txtBirthday.Size = New Size(186, 30)
        txtBirthday.TabIndex = 6
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(650, 334)
        Controls.Add(txtBirthday)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtFullname)
        Controls.Add(lblAddress)
        Controls.Add(lblBirthday)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblFullname)
        Controls.Add(barDockControlLeft)
        Controls.Add(barDockControlRight)
        Controls.Add(barDockControlBottom)
        Controls.Add(barDockControlTop)
        Name = "frmAddStudent"
        Text = "Add Student"
        CType(txtFullname.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(txtEmail.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(txtPhone.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(txtAddress.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(BarManager1, ComponentModel.ISupportInitialize).EndInit()
        CType(txtBirthday.Properties.CalendarTimeProperties, ComponentModel.ISupportInitialize).EndInit()
        CType(txtBirthday.Properties, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFullname As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPhone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBirthday As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnReset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtBirthday As DevExpress.XtraEditors.DateEdit
End Class
