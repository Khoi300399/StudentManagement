
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting

Public Class frmStudentList
    Dim connect As Connect = New Connect
    Dim dt As DataTable
    Private Sub frmStudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            source()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub source()
        connect.Initialize()
        dt = connect.getDataTable("SELECT * FROM dt_student")
        dt.TableName = "dt_student"
        grid.DataSource = dt
    End Sub

    Private Sub detail_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles detail.RowUpdated
        Try
            connect.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub detail_InvalidValueException(sender As Object, e As InvalidValueExceptionEventArgs) Handles detail.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub detail_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles detail.ValidateRow
        If Convert.ToString(detail.GetRowCellValue(e.RowHandle, "fullname")) = "" Then
            detail.SetColumnError(detail.Columns("fullname"), "Please enter your fullname")
            e.Valid = False
            MsgBox("Please enter your fullname")
            Return
        End If

        If Convert.ToString(detail.GetRowCellValue(e.RowHandle, "email")) = "" Then
            detail.SetColumnError(detail.Columns("email"), "Please enter your email")
            e.Valid = False
            MsgBox("Please enter your email")
            Return
        End If

        If Convert.ToString(detail.GetRowCellValue(e.RowHandle, "birthday")) = "" Then
            detail.SetColumnError(detail.Columns("birthday"), "Please enter your birthday")
            e.Valid = False
            MsgBox("Please enter your birthday")
            Return
        End If

        If Convert.ToString(detail.GetRowCellValue(e.RowHandle, "phone")) = "" Then
            detail.SetColumnError(detail.Columns("phone"), "Please enter your phone")
            e.Valid = False
            MsgBox("Please enter your phone")
            Return
        End If

        If Convert.ToString(detail.GetRowCellValue(e.RowHandle, "address")) = "" Then
            detail.SetColumnError(detail.Columns("address"), "Please enter your address")
            e.Valid = False
            MsgBox("Please enter your address")
            Return
        End If
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            If MsgBox("Are you sure you want to delete this data?", MsgBoxStyle.YesNo, "Warning!") = MsgBoxResult.Yes Then
                connect.queryingData("DELETE dt_student WHERE id = N'" & Convert.ToString(detail.GetRowCellValue(detail.FocusedRowHandle, "id")) & "'")
                source()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Dim Link As New PrintableComponentLink(New PrintingSystem())
        Link.Component = grid
        Link.CreateDocument()
        Dim frm As New PrintTool(Link.PrintingSystemBase)
        frm.PreviewForm.Name = "studentlist"
        frm.PreviewForm.Text = "studentlist"
        frm.ShowPreview()
    End Sub

    Private Sub btnNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        Dim frm As New frmAddStudent
        frm.ShowDialog()
        source()
    End Sub


End Class